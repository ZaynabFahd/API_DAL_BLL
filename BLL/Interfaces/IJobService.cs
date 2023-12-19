
using BLL.Models.FormJob;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Interfaces
{
    public interface IJobService
    {
        IEnumerable<Job> GetAll();

        Job? GetById(int id);

        Job? Create(CreateJobForm form);

        bool Update(int id, UpdateJobForm form);

        bool Delete(int id);
    }
}
