using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public class MemberRepo
    {
        private BookishContext _context = new BookishContext();

        public Member GetMemberById(int id)
        {
            return _context
            .Members
            .Where(b => b.Id == id)
            .Single();
        }

        public List<Member> GetAllMembers()
        {
            return _context
            .Members
            .ToList();
        }
    }
}