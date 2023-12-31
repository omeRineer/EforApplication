﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkTimeApp.DataBase;

namespace WorkTimeApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230716121726_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("WorkTimeApp.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WorkTimeApp.Entities.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("WorkTimeApp.Entities.WorkTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuestId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId1");

                    b.HasIndex("QuestId1");

                    b.ToTable("WorkTimes");
                });

            modelBuilder.Entity("WorkTimeApp.Entities.WorkTime", b =>
                {
                    b.HasOne("WorkTimeApp.Entities.Project", "Project")
                        .WithMany("WorkTimes")
                        .HasForeignKey("ProjectId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkTimeApp.Entities.Quest", "Quest")
                        .WithMany("WorkTimes")
                        .HasForeignKey("QuestId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("WorkTimeApp.Entities.Project", b =>
                {
                    b.Navigation("WorkTimes");
                });

            modelBuilder.Entity("WorkTimeApp.Entities.Quest", b =>
                {
                    b.Navigation("WorkTimes");
                });
#pragma warning restore 612, 618
        }
    }
}
