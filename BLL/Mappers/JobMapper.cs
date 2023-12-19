using BLL.Models.FormJob;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class JobMapper
    {
        public static Job ToJob(this CreateJobForm form)
        {
            return new Job()
            {
                Name = form.Name,
                MinimalSalary = form.MinimalSalary,
                CP = form.CP,
                Sector = form.Sector,
                Id = 0
            };
        }
    }
}
