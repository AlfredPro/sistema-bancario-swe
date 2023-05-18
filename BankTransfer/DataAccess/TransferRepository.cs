using BankTransfer.Models;

namespace BankTransfer.DataAccess
{
    public class TransferRepository
    {
        private readonly DbContext _context;

        public TransferRepository(DbContext context)
        {
            _context = context;
        }

        public void CreateTransfer(Transfer transfer)
        {
            _context.Transfers.Add(transfer);
            _context.SaveChanges();
        }
    }
}
