using System.Collections.Generic;
using System.Linq;
using expensesapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace expensesapi.Controllers
{
    [Route("api/[controller]")]
    public class ExpensesController : Controller
    {
        private readonly ExpenseContext _context;

        public ExpensesController(ExpenseContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return _context.Expenses.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Expense Get(int id)
        {
            return _context.Expenses.FirstOrDefault(e => e.ExpenseId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Expense expense)
        {
            _context.Add(expense);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Expense expense)
        {
            _context.Update(expense);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var expense = _context.Expenses.FirstOrDefault(e => e.ExpenseId == id);

            _context.Remove(expense);
            _context.SaveChanges();
        }
    }
}
