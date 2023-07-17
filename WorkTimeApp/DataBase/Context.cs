using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeApp.Entities;

namespace WorkTimeApp.DataBase
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WorkTimeDb.db");
        }

        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
