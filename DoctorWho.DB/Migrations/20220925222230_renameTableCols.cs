using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class renameTableCols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemy",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EpisodeType",
                table: "Episode",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "EpisodeId",
                table: "Episode",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EnemyName",
                table: "Enemy",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EnemyId",
                table: "Enemy",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorNumber",
                table: "Doctor",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "Doctor",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompanionName",
                table: "Companion",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CompanionId",
                table: "Companion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Author",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Author",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EpisodeEnemy",
                newName: "EpisodeEnemyId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EpisodeCompanion",
                newName: "EpisodeCompanionId");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Episode",
                newName: "EpisodeType");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Episode",
                newName: "EpisodeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Enemy",
                newName: "EnemyName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Enemy",
                newName: "EnemyId");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Doctor",
                newName: "DoctorNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctor",
                newName: "DoctorName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctor",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companion",
                newName: "CompanionName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companion",
                newName: "CompanionId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Author",
                newName: "AuthorName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Author",
                newName: "AuthorId");
        }
    }
}
