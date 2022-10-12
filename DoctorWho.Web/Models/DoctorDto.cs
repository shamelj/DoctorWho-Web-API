namespace DoctorWho.Web.Models
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? FirstEpisodeDate { get; set; }
        public DateTime? LastEpisodeDate { get; set; }
    }
}