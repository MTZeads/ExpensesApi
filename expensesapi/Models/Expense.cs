using System;

namespace expensesapi.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }        
        public DateTime PaidDate { get; set; }        
        public Person Person { get; set; }
    }
}
