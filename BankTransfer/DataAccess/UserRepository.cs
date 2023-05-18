using BankTransfer.Models;

using System.Linq;

namespace BankTransfer.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public User GetUserByAccountNumber(string accountNumber)
        {
            return _context.Users.FirstOrDefault(u => u.AccountNumber == accountNumber);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
