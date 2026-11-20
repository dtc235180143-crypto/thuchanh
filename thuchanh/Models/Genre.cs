namespace day6_2._0.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}