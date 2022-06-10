namespace Bookish
{
    public class MemberCopy
    {
        public int Id { get; set; }
        public Copy Copy { get; set; }
        public Member Member { get; set; }
        public DateTime DueDate { get; set; }
        public bool Returned { get; set; }
    }
}