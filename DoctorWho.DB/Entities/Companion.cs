using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;
[Table("Companion")]
public class Companion
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string WhoPlayed { get; set; }
    #region Navigation properties
    public List<EpisodeCompanion> EpisodeCompanions { get; set; }
    #endregion
}
