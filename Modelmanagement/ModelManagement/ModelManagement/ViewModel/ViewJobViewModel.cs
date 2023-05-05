using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.ViewModel
{
    public class ViewJobViewModel
    {
        private Job _job;

        public ViewJobViewModel(Job job)
        {
            _job = job;
        }

        public string Title
        {
            get { return _job.Title; }
        }

        public string Description
        {
            get { return _job.Description; }
        }


        public List<Model> Models
        {
            get { return _job.Models; }
        }

        public List<Expense> Expenses
        {
            get { return _job.Expenses; }
        }
    }

}
