using API_DAL_BLL.Models.DTO;
using DAL.Entities;

namespace API_DAL_BLL.Mappers
{
    public static class JobMapper
    {
        public static JobDTO ToDTO(this Job job)
        {
            return new JobDTO()
            {
                Id = job.Id,
                Name = job.Name,
                MinimalSalary = job.MinimalSalary,
                CP = job.CP,
                Sector = job.Sector
            };
        }
    }
}
