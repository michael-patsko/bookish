using Bookish.Repositories;
using Bookish.Models;

namespace Bookish.Services
{
    public class MemberService
    {
        private MemberRepo _memberRepo = new MemberRepo();

        public Member GetMemberById(int id)
        {
            return _memberRepo.GetMemberById(id);
        }

        public List<Member> GetAllMembers()
        {
            return _memberRepo.GetAllMembers();
        }
    }
}