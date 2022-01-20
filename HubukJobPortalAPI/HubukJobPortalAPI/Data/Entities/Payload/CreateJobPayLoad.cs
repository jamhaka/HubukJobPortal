using HubukJobPortalAPI.Data.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace HubukJobPortalAPI.Data.Entities.Payload
{
    public class CreateJobPayLoad
    {
        [Required]
        public string JobName { get; set; }
        [Required]
        public string JobOpportunity { get; set; }
        [Required(ErrorMessage ="Ops! Please Give the Job Description you are about to create")]
        public string JobDescription { get; set; }
        [Required(ErrorMessage ="Skills need to be specify")]
        public string JobSkills { get; set; }
        [Required(ErrorMessage = "Please Specify the Job Type")]
        public SelectJob JobType { get; set; }
        [Required(ErrorMessage ="Give the nature of Job you are about to create")]
        public Nature JobNature { get; set; }
        [Required(ErrorMessage ="Please is Job you are about to create Open or Closed?")]
        public JobStatus Status { get; set; }

    }
}
