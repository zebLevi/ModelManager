using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;


namespace ModelManagement.Models
{
    public class Model
    {
       
            
            public string Name { get; set; }

            public string Email { get; set; }
            public string Description { get; set; }
            public List<Job> Jobs { get; set; }
        
    }
}

  
