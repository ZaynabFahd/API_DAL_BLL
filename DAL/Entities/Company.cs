using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace DAL.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Localisation { get; set; }
        public int TVA { get; set; }

    }
}
