using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.Models
{
    public class Expense
    {
       
        
            public int ExpenseId { get; set; }
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }
        
    }
}

