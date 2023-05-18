using BankTransfer.Models;
namespace BankTransfer.DataAccess
{
    public interface IUserRepository
    {
        User GetUserByAccountNumber(string accountNumber);
        void UpdateUser(User user);
    }
}
