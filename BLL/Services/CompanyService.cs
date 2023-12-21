using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.CompanyForm;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public Company? Create(CreateCompanyForm form)
        {
            Company? company = _companyRepository.GetByTVA(form.TVA);

            if (company is null)
            {
                return _companyRepository.Create(form.ToCompany());
            }

            return null;
        }

        public bool Delete(int id)
        {
            Company? company = _companyRepository.GetById(id);

            if (company is not null)
            {
                return _companyRepository.Delete(company);
            }

            return false;
        }

        public IEnumerable<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public Company? GetById(int id)
        {
            return _companyRepository.GetById(id);
        }

        public bool Update(int id, UpdateCompanyForm form)
        {
            Company? company = _companyRepository.GetById(id);
            if (company is  not null)
            {
                company.Name = form.Name;
                company.TVA = form.TVA;

                return _companyRepository.Update(company);
            }
            return false;
        }
    }
}
