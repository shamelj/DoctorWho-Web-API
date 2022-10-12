using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class renamedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemys_Enemys_EnemyId",
                table: "EpisodeEnemys");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemys_Episodes_EpisodeId",
                table: "EpisodeEnemys");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeEnemys",
                table: "EpisodeEnemys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enemys",
                table: "Enemys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companions",
                table: "Companions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Episodes",
                newName: "Episode");

            migrationBuilder.RenameTable(
                name: "EpisodeEnemys",
                newName: "EpisodeEnemy");

            migrationBuilder.RenameTable(
                name: "EpisodeCompanions",
                newName: "EpisodeCompanion");

            migrationBuilder.RenameTable(
                name: "Enemys",
                newName: "Enemy");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameTable(
                name: "Companions",
                newName: "Companion");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_DoctorId",
                table: "Episode",
                newName: "IX_Episode_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_AuthorId",
                table: "Episode",
                newName: "IX_Episode_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeEnemys_EpisodeId",
                table: "EpisodeEnemy",
                newName: "IX_EpisodeEnemy_EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeEnemys_EnemyId",
                table: "EpisodeEnemy",
                newName: "IX_EpisodeEnemy_EnemyId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeCompanions_EpisodeId",
                table: "EpisodeCompanion",
                newName: "IX_EpisodeCompanion_EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeCompanions_CompanionId",
                table: "EpisodeCompanion",
                newName: "IX_EpisodeCompanion_CompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episode",
                table: "Episode",
                column: "EpisodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeEnemy",
                table: "EpisodeEnemy",
                column: "EpisodeEnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeCompanion",
                table: "EpisodeCompanion",
                column: "EpisodeCompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enemy",
                table: "Enemy",
                column: "EnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companion",
                table: "Companion",
                column: "CompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Author_AuthorId",
                table: "Episode",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Doctor_DoctorId",
                table: "Episode",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanion_Companion_CompanionId",
                table: "EpisodeCompanion",
                column: "CompanionId",
                principalTable: "Companion",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanion_Episode_EpisodeId",
                table: "EpisodeCompanion",
                column: "EpisodeId",
                principalTable: "Episode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemy_Enemy_EnemyId",
                table: "EpisodeEnemy",
                column: "EnemyId",
                principalTable: "Enemy",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemy_Episode_EpisodeId",
                table: "EpisodeEnemy",
                column: "EpisodeId",
                principalTable: "Episode",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Author_AuthorId",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Doctor_DoctorId",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanion_Companion_CompanionId",
                table: "EpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCompanion_Episode_EpisodeId",
                table: "EpisodeCompanion");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemy_Enemy_EnemyId",
                table: "EpisodeEnemy");

            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeEnemy_Episode_EpisodeId",
                table: "EpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeEnemy",
                table: "EpisodeEnemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeCompanion",
                table: "EpisodeCompanion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episode",
                table: "Episode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enemy",
                table: "Enemy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companion",
                table: "Companion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "EpisodeEnemy",
                newName: "EpisodeEnemys");

            migrationBuilder.RenameTable(
                name: "EpisodeCompanion",
                newName: "EpisodeCompanions");

            migrationBuilder.RenameTable(
                name: "Episode",
                newName: "Episodes");

            migrationBuilder.RenameTable(
                name: "Enemy",
                newName: "Enemys");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "Companion",
                newName: "Companions");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeEnemy_EpisodeId",
                table: "EpisodeEnemys",
                newName: "IX_EpisodeEnemys_EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeEnemy_EnemyId",
                table: "EpisodeEnemys",
                newName: "IX_EpisodeEnemys_EnemyId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeCompanion_EpisodeId",
                table: "EpisodeCompanions",
                newName: "IX_EpisodeCompanions_EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_EpisodeCompanion_CompanionId",
                table: "EpisodeCompanions",
                newName: "IX_EpisodeCompanions_CompanionId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_DoctorId",
                table: "Episodes",
                newName: "IX_Episodes_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_AuthorId",
                table: "Episodes",
                newName: "IX_Episodes_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeEnemys",
                table: "EpisodeEnemys",
                column: "EpisodeEnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions",
                column: "EpisodeCompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episodes",
                table: "Episodes",
                column: "EpisodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enemys",
                table: "Enemys",
                column: "EnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companions",
                table: "Companions",
                column: "CompanionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Companions_CompanionId",
                table: "EpisodeCompanions",
                column: "CompanionId",
                principalTable: "Companions",
                principalColumn: "CompanionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCompanions_Episodes_EpisodeId",
                table: "EpisodeCompanions",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemys_Enemys_EnemyId",
                table: "EpisodeEnemys",
                column: "EnemyId",
                principalTable: "Enemys",
                principalColumn: "EnemyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeEnemys_Episodes_EpisodeId",
                table: "EpisodeEnemys",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "EpisodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Authors_AuthorId",
                table: "Episodes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Doctors_DoctorId",
                table: "Episodes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
