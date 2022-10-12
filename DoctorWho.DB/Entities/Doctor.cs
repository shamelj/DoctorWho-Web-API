using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;
[Table("Doctor")]
public class Doctor
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime FirstEpisodeDate { get; set; }
    public DateTime LastEpisodeDate { get; set; }

    #region Navigation properties
    public List<Episode> Episodes { get; set; }
    #endregion

}