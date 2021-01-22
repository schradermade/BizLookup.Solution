using Microsoft.EntityFrameworkCore;

namespace BizLookupApi.Models
{
    public class BizLookupApiContext : DbContext
    {
        public BizLookupApiContext(DbContextOptions<BizLookupApiContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
    }
}