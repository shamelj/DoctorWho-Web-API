using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class functions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION fnCompanions (@Episodeid int)
                                    RETURNS varchar(255)
                                    AS
                                    BEGIN
                                        DECLARE @Companions VARCHAR(MAX)
                                        SELECT @Companions = COALESCE(@Companions + ', ', '') + C.CompanionName
                                        FROM EpisodeCompanion E JOIN Companion C 
	                                        ON E.CompanionId = C.CompanionId
                                        WHERE E.EpisodeId = @Episodeid;

                                        RETURN @Companions;
                                    end;");
            migrationBuilder.Sql(@"CREATE FUNCTION fnEnemies (@Episodeid int)
                                    RETURNS varchar(255)
                                    AS
                                    BEGIN
	                                    DECLARE @Enemies VARCHAR(MAX)
	                                    SELECT @Enemies = COALESCE(@Enemies + ', ', '') + Enemy.EnemyName
	                                    FROM EpisodeEnemy JOIN Enemy 
		                                    ON EpisodeEnemy.EnemyId = Enemy.EnemyId
	                                    WHERE EpisodeEnemy.EpisodeId = @Episodeid;
	                                    RETURN @Enemies;
                                    end;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION fnCompanions ");
            migrationBuilder.Sql(@"DROP FUNCTION fnEnemies ");

        }
    }
}
