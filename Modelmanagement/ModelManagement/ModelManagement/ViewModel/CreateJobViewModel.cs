using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.ViewModel
{
    public class CreateJobViewModel
    {
        private List<Model> _models;
        private List<Expense> _expenses;

        public CreateJobViewModel()
        {
            _models = new List<Model>();
            _expenses = new List<Expense>();
        }

        public string Title { get; set; }
        public string Description { get; set; }

        


        public void AddModel(Model model)
        {
            _models.Add(model);
        }

        //public void AddExpense(Expense expense)
        ////{
        ////    _expenses.Add(expense);
        ////}

        public Job GetJob()
        {
            var job = new Job
            {
                Title = Title,
                Description = Description,
                Models = _models,
                Expenses = _expenses
            };

            return job;
        }
    }
}
