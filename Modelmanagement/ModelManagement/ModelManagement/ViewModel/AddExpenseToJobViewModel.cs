using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.ViewModel
{
    public class AddExpenseToJobViewModel
    {
        private Job _job;

        public AddExpenseToJobViewModel(Job job)
        {
            _job = job;
        }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public void AddExpenseToJob()
        {
            var expense = new Expense
            {
                Amount = Amount,
                Date = Date,
                Description = Description
            };

            _job.Expenses.Add(expense);
        }
    }
}
