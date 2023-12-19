using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.FormJob
{
    public class UpdateJobForm
    {
        public string Name { get; set; }

        public string Sector { get; set; }

        public string CP { get; set; }

        public int MinimalSalary { get; set; }
    }
}
