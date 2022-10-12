using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class procedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE spSummariseEpisodes
                                    AS
                                    BEGIN

                                        SELECT TOP 3 CompanionId, COUNT(*) AS Count

                                        FROM EpisodeCompanion

                                        GROUP BY CompanionId

                                        ORDER BY COUNT(*) DESC


                                        SELECT TOP 3 EnemyId, COUNT(*) AS Count

                                        FROM EpisodeEnemy

                                        GROUP BY EnemyId

                                        ORDER BY COUNT(*) DESC

                                    END; "
                                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE spSummariseEpisodes;");

        }
    }
}
