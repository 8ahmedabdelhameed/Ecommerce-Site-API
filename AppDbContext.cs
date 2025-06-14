using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;

namespace WebApplication3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Customer>  customers { get; set; }
        public DbSet<BankCard> bankCards    { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Transcation> Transcations { get; set; }
    }
}
