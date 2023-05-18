using System.ComponentModel.DataAnnotations;
namespace BankTransfer.Models
{
    public class Transfer
    {
        public Transfer(/*int id,*/ int senderId, int receiverId, decimal amount, DateTime date)
        {
            //Id = id;
            SenderId = senderId;
            ReceiverId = receiverId;
            Amount = amount;
            Date = date;
        }

        //[Required]
        //public readonly int Id;
        [Required]
        public readonly int SenderId;
        [Required]
        public readonly int ReceiverId;
        [Required]
        [DataType(DataType.Currency)]
        public readonly decimal Amount;
        [Required]
        [DataType(DataType.DateTime)]
        public readonly DateTime Date;
    }
}
