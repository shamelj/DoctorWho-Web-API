using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;
[Table("EpisodeEnemy")]
public class EpisodeEnemy
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    #region Navigation properties
    public Enemy Enemy { get; set; }
    public Episode Episode { get; set; }
    #endregion

    #region FKs
    public int EnemyId { get; set; }
    public int EpisodeId { get; set; }
    #endregion


}
