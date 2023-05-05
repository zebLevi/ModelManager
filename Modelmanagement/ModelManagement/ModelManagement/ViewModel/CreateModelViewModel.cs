using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.ViewModel
{
    public class CreateModelViewModel
    {
        private List<Job> _jobs;

        public CreateModelViewModel()
        {
            _jobs = new List<Job>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public string Email { get; set; }


        public void AddJob(Job job)
        {
            _jobs.Add(job);
        }

        public Model GetModel()
        {
            var model = new Model
            {
                Name = Name,
                Description = Description,
                Email = Email,
                Jobs = _jobs
            };

            return model;
        }
    }
}
