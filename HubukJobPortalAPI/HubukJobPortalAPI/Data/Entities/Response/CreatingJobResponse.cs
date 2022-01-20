using HubukJobPortalAPI.Data.Entities.Enums;

namespace HubukJobPortalAPI.Data.Entities.Response
{
    public class CreatingJobResponse
    {
        public string JobName { get; set; } = String.Empty;
        public JobStatus Status { get; set; }
    }
}
