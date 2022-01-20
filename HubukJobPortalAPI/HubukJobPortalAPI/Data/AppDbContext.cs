using Microsoft.EntityFrameworkCore;
using HubukJobPortalAPI.Data.Entities.Models;

namespace HubukJobPortalAPI.Data
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            _options = options;
        }
        public DbSet<HubukJobPortalAPI.Data.Entities.Models.Job> Jobs { get; set; }
    }
}
