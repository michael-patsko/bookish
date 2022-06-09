namespace Bookish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author_id { get; set; }
        public int Genre_id { get; set; }
        public int Year_published { get; set; }
    }
}