using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.DB.Migrations
{
    public partial class views : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW viewEpisodes AS
                                    SELECT EpisodeId,
	                                    Title,
	                                    AuthorName,
	                                    DoctorName,
	                                    dbo.fnCompanions(EpisodeId) AS Companions,
	                                    dbo.fnEnemies(EpisodeId) AS Enemies
                                    FROM Episode
                                    JOIN Doctor ON Episode.DoctorId = Doctor.DoctorId
                                    JOIN Author ON Episode.AuthorId = Author.AuthorId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW viewEpisodes");
        }
    }
}
