namespace music.Models
{
    public class MusicVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

}
