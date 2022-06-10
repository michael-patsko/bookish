namespace Bookish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public Genre Genre { get; set; }
        public string CoverImageUrl { get; set; }
        public int YearPublished { get; set; }
        public string Blurb { get; set; }
        public List<Copy> Copies { get; set; }
    }
}