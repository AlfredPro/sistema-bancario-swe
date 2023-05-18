using BankTransfer.Models;
using Microsoft.EntityFrameworkCore;

namespace BankTransfer.DataAccess
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

    }
}
