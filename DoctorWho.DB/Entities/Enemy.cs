using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;

[Table("Enemy")]
public class Enemy
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    #region Navigation properties
    public List<EpisodeEnemy> EpisodeEnemys { get; set; }
    #endregion

}
