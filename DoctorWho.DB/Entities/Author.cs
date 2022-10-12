using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.DB.models;
[Table("Author")]
public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }

    #region Navigation properties
    public List<Episode> Episodes { get; set; }
    #endregion
}
