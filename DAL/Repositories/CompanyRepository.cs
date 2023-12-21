using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public Company? Create(Company company)
        {
            company.Id = FakeDB.Companies.Max(x => x.Id) + 1;

            FakeDB.Companies.Add(company);

            return company;
        }

        public bool Delete(Company company)
        {
            FakeDB.Companies.Remove(company);
            return true;
        }

        public IEnumerable<Company> GetAll()
        { 
            return FakeDB.Companies;
        }

        public Company? GetById(int id)
        {
            return FakeDB.Companies.SingleOrDefault(x => x.Id == id);

        }

        public Company? GetByTVA(int tva)
        {
            return FakeDB.Companies.SingleOrDefault(x => x.TVA == tva);
        }

        public bool Update(Company company)
        {
            int index = FakeDB.Companies.FindIndex(x => x.Id == company.Id);

            FakeDB.Companies[index] = company;

            return true;
        }
    }
}
