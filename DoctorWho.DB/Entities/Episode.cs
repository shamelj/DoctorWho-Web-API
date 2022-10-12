using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;

[Table("Episode")]
public class Episode
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int SeriesNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public DateTime EpisodeDate { get; set; }
    public string Notes { get; set; }

    #region Navigation properties
    public Author Author { get; set; }
    public Doctor Doctor { get; set; }
    public List<EpisodeEnemy> EpisodeEnemies { get; set; }
    public List<EpisodeCompanion> EpisodeCompanions { get; set; }

    #endregion

    #region FKs
    public int AuthorId { get; set; }
    public int DoctorId { get; set; }
    #endregion
}
