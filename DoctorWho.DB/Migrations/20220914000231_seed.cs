using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Karm" },
                    { 2, "Lama" },
                    { 3, "Sara" },
                    { 4, "Safadi" },
                    { 5, "Hisham" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Comp1", "none" },
                    { 2, "Comp2", "none" },
                    { 3, "Comp3", "none" },
                    { 4, "Comp4", "none" },
                    { 5, "Comp5", "none" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "BirthDate", "DoctorName", "DoctorNumber", "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1977, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shamel", 1, new DateTime(2010, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 3, 2, 30, 986, DateTimeKind.Local).AddTicks(2866) },
                    { 2, new DateTime(1978, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmad", 2, new DateTime(2011, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 3, 2, 30, 986, DateTimeKind.Local).AddTicks(2925) },
                    { 3, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omar", 3, new DateTime(2012, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 3, 2, 30, 986, DateTimeKind.Local).AddTicks(2932) },
                    { 4, new DateTime(1911, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sami", 4, new DateTime(2210, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 3, 2, 30, 986, DateTimeKind.Local).AddTicks(2937) },
                    { 5, new DateTime(1987, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shamel", 5, new DateTime(2009, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 3, 2, 30, 986, DateTimeKind.Local).AddTicks(2942) }
                });

            migrationBuilder.InsertData(
                table: "Enemys",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "desc1", "evil1" },
                    { 2, "desc2", "evil2" },
                    { 3, "desc3", "evil3" },
                    { 4, "desc4", "evil4" },
                    { 5, "desc5", "evil5" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "Notes", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "type1", "note1", 1, "t1" },
                    { 2, 2, 2, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "type2", "note2", 2, "t2" },
                    { 3, 3, 3, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "type3", "note3", 3, "t3" },
                    { 4, 4, 4, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "type4", "note4", 4, "t4" },
                    { 5, 5, 5, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "type5", "note5", 5, "t5" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemys",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemys",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemys",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);
        }
    }
}
