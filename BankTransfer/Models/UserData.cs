using System.ComponentModel.DataAnnotations;
namespace BankTransfer.Models
{
    public class UserData
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
