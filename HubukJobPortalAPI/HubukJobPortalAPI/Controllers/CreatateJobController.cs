using HubukJobPortalAPI.Data;
using HubukJobPortalAPI.Data.Entities.Models;
using HubukJobPortalAPI.Data.Entities.Payload;
using HubukJobPortalAPI.Data.Entities.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HubukJobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatateJobController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CreatateJobController(AppDbContext context)
        {
            _context = context; 
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async  Task<ActionResult> CreateJob([FromBody] CreateJobPayLoad createJobPayLoad)
        {
            var job = new Job();

            job.JobName = createJobPayLoad.JobName;
            job.JobOpportunity = createJobPayLoad.JobOpportunity;
            job.JobDescription = createJobPayLoad.JobDescription;
            job.JobNature = createJobPayLoad.JobNature;
            job.JobType = createJobPayLoad.JobType;
            job.JobSkills = createJobPayLoad.JobSkills;
            job.Status = createJobPayLoad.Status;

            _context.Add(job);
            await _context.SaveChangesAsync();

            var respone = new CreatingJobResponse()
            {
                JobName = createJobPayLoad.JobName,
                Status = createJobPayLoad.Status,
            };

            return Ok(respone);
        }

        [HttpGet("GetJob")]
        public async Task<ActionResult> AvailableJobs() 
        {
            var availableJobs = _context.Jobs.AsQueryable();
            return Ok(availableJobs);
        }
        [HttpPost("UpdateJob")]
        public Job UpdateJobById(int id, [FromBody]CreateJobPayLoad createJobPayLoad)
        {
            var _Job = _context.Jobs.FirstOrDefault(n => n.Id == id);
            if(_Job != null)
            {
                _Job.JobName = createJobPayLoad.JobName;
                _Job.JobOpportunity = createJobPayLoad.JobOpportunity;
                _Job.JobDescription = createJobPayLoad.JobDescription;
                _Job.JobNature = createJobPayLoad.JobNature;
                _Job.JobType = createJobPayLoad.JobType;
                _Job.JobSkills = createJobPayLoad.JobSkills;
                _Job.Status = createJobPayLoad.Status;
                _context.SaveChanges(); 
            }
            return _Job;
        }
        [HttpDelete("DeleteJob/{id}")]
        public void DeleteJobById (int id)
        {
            var _job = _context.Jobs.FirstOrDefault(n => n.Id == id);
            if( _job != null )
            {
                _context.Jobs.Remove( _job );
                _context.SaveChanges();
            }
        }
            

    }
}
