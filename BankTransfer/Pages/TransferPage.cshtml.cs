using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BankTransfer.Models;
using System;

namespace BankTransfer.Pages
{
    public class TransferPageModel : PageModel
    {
        private readonly DataAccess.UserRepository _userRepository;
        private readonly DataAccess.TransferRepository _transferRepository;

        public TransferPageModel(DataAccess.UserRepository userRepository, DataAccess.TransferRepository transferRepository)
        {
            _userRepository = userRepository;
            _transferRepository = transferRepository;
        }

        [BindProperty]
        public string ReceiverAccountNumber { get; set; }

        [BindProperty]
        public decimal Amount { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Retrieve the sender's account based on the user's authentication
            // (You can implement user authentication logic here or modify it to fit your authentication system)
            var senderAccount = _userRepository.GetUserByAccountNumber("SenderAccountNumber");

            // Check if the sender has sufficient balance
            if (senderAccount.Balance < Amount)
            {
                ModelState.AddModelError(string.Empty, "Insufficient balance.");
                return Page();
            }

            // Retrieve the receiver's account
            var receiverAccount = _userRepository.GetUserByAccountNumber(ReceiverAccountNumber);

            // Transfer money
            senderAccount.Balance -= Amount;
            receiverAccount.Balance += Amount;

            // Create transfer record
            var transfer = new Transfer
            (
                senderAccount.Id,
                receiverAccount.Id,
                Amount,
                DateTime.UtcNow
            );

            _transferRepository.CreateTransfer(transfer);

            // Update the sender and receiver accounts in the database
            _userRepository.UpdateUser(senderAccount);
            _userRepository.UpdateUser(receiverAccount);

            return RedirectToPage("Index"); // Redirect to the transfer money page after the transfer is complete
        }
    }
}
        