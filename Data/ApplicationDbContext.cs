using Microsoft.EntityFrameworkCore;

namespace ContinuousIntegrationWithCoreMvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
