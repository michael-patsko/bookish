namespace Bookish.Models
{
    public class CreateBook
    {
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public string YearPublished { get; set; }
        public string Blurb { get; set; }
        public int GenreId { get; set; }
    }
}
