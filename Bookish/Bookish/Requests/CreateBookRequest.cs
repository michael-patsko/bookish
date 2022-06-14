namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public int YearPublished { get; set; }
        public string Blurb { get; set; }
        public int GenreId { get; set; }
    }
}
