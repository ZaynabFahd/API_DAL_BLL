using BLL.Models.CompanyForm;
using BLL.Models.FormJob;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAll();

        Company? GetById(int id);

        Company? Create(CreateCompanyForm form);

        bool Update(int id, UpdateCompanyForm form);

        bool Delete(int id);
    }
}
