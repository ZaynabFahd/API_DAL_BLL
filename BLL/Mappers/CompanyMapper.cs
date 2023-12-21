using BLL.Models.CompanyForm;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class CompanyMapper
    {
        public static Company ToCompany(this CreateCompanyForm form)
        {
            return new Company()
            {
                Id = 0,
                Name = form.Name,
                Localisation = form.Localisation,
                TVA = form.TVA,
            };
        }
    }
}
