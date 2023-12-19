using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.FormJob;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public IEnumerable<Job> GetAll()
        {
            return _jobRepository.GetAll();
        }

        public Job? GetById(int id)
        {
            return _jobRepository.GetById(id);
        }

        public Job? Create(CreateJobForm form)
        {
            return _jobRepository.Create(form.ToJob());
        }

        public bool Update(int id, UpdateJobForm form)
        {
            Job? job = _jobRepository.GetById(id);

            if (job is not null)
            {
                job.MinimalSalary = form.MinimalSalary;
                job.CP = form.CP;
                job.Name = form.Name;
                job.Sector = form.Sector;

                return _jobRepository.Update(job);
            }

            return false;
        }

        public bool Delete(int id)
        {
            Job? job = _jobRepository.GetById(id);

            if (job is not null)
            {
                return _jobRepository.Delete(job);
            }

            return false;
        }
    }
}
