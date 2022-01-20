using HubukJobPortalAPI.Data.Entities.Enums;

namespace HubukJobPortalAPI.Data.Entities.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; } =   String.Empty;
        public string JobOpportunity { get; set; } = String.Empty;
        public string JobDescription { get; set; } = String.Empty ;
        public string JobSkills { get; set; } = String.Empty;
        public SelectJob JobType { get; set; }
        public Nature JobNature { get; set; }
        public JobStatus Status { get; set; }
    }
}
