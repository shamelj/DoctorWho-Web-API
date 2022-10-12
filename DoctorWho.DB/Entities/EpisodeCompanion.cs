using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;
[Table("EpisodeCompanion")]
public class EpisodeCompanion
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    #region Navigation properties
    public Companion Companion { get; set; }
    public Episode Episode { get; set; }
    #endregion

    #region FKs
    public int CompanionId { get; set; }
    public int EpisodeId { get; set; }
    #endregion


}