using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelManagement.Models;

namespace ModelManagement.Models
{
    internal class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerAddress { get; set; }
    }
}
