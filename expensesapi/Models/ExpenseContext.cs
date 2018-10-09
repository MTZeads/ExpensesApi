using Microsoft.EntityFrameworkCore;

namespace expensesapi.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base(options)
        { }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
