namespace DoctorWho.Web.Models;

public class EpisodeCreationDto
{
    public int SeriesNumber { get; set; }
    public int EpisodeNumber { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public DateTime EpisodeDate { get; set; }
    public string Notes { get; set; }
    public int AuthorId { get; set; }
    public int DoctorId { get; set; }
}