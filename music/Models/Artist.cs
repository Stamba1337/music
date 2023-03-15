namespace music.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<MusicVideo> SongsList { get; set; }
        public List<Genre> GenreList { get; set; }
    }

}
