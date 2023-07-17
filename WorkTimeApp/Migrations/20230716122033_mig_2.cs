using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkTimeApp.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Projects_ProjectId1",
                table: "WorkTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Quests_QuestId1",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_ProjectId1",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_QuestId1",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "WorkTimes");

            migrationBuilder.DropColumn(
                name: "QuestId1",
                table: "WorkTimes");

            migrationBuilder.AlterColumn<int>(
                name: "QuestId",
                table: "WorkTimes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "WorkTimes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_ProjectId",
                table: "WorkTimes",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_QuestId",
                table: "WorkTimes",
                column: "QuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Projects_ProjectId",
                table: "WorkTimes",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Quests_QuestId",
                table: "WorkTimes",
                column: "QuestId",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Projects_ProjectId",
                table: "WorkTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Quests_QuestId",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_ProjectId",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_QuestId",
                table: "WorkTimes");

            migrationBuilder.AlterColumn<string>(
                name: "QuestId",
                table: "WorkTimes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "WorkTimes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId1",
                table: "WorkTimes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestId1",
                table: "WorkTimes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_ProjectId1",
                table: "WorkTimes",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_QuestId1",
                table: "WorkTimes",
                column: "QuestId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Projects_ProjectId1",
                table: "WorkTimes",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Quests_QuestId1",
                table: "WorkTimes",
                column: "QuestId1",
                principalTable: "Quests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
