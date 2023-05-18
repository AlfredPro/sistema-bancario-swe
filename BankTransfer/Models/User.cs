using System.ComponentModel.DataAnnotations;
namespace BankTransfer.Models
{
    public class User
    {
        public User(int id, string accountNumber, string firstName, string lastName, string password, decimal balance, string token)
        {
            Id = id;
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Balance = balance;
            Token = token;
        }

        [Required]
        public readonly int Id;
        [Required]
        [DataType(DataType.Text)]
        public readonly string AccountNumber;
        [Required]
        [DataType(DataType.Text)]
        public readonly string FirstName;
        [Required]
        [DataType(DataType.Text)]
        public readonly string LastName;
        [Required]
        [DataType(DataType.Password)]
        public readonly string Password;
        [Required]
        [DataType(DataType.Currency)]
        public decimal Balance;
        [Required]
        [DataType(DataType.Text)]
        public readonly string Token;
    }
}
