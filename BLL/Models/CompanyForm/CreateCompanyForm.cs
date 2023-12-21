using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.CompanyForm
{
    public class CreateCompanyForm
    {
        public string? Name { get; set; }

        [MinLength(6)]
        public int TVA { get; set; }

        public string Localisation { get; set; }
    }
}
