using Microsoft.EntityFrameworkCore;

namespace HubukJobPortalAPI.Data
{
    public class AppDbContext : DbContext
    {
        private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            _options = options;
        }
    }
}
