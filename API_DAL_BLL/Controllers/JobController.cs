using API_DAL_BLL.Mappers;
using API_DAL_BLL.Models.DTO;
using BLL.Interfaces;
using BLL.Models.FormJob;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DAL_BLL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<JobDTO>> GetAll()
        {
            return Ok(_jobService.GetAll().Select(x => x.ToDTO()));
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<JobDTO> GetById(int id)
        {
            Job? job = _jobService.GetById(id);

            return job is not null ? Ok(job) : NotFound();
        }

        [HttpPost]
        public ActionResult<JobDTO> Create(CreateJobForm form)
        {
            Job? job = _jobService.Create(form);

            return job is not null ? Ok(job) : BadRequest();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, UpdateJobForm form)
        {
            return _jobService.Update(id, form) ? NoContent() : BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete(int id)
        {
            return _jobService.Delete(id) ? NoContent() : BadRequest();
        }
    }
}
