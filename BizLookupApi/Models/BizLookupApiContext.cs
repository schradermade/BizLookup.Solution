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
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Business>()
            .HasData(
                new Business { BusinessId = 1, Name = "Blue Dolphin Wash", Industry = "Retail", Address = "Newberg, Oregon", Hours = "8am-6pm, 7 days/Week" },
                new Business { BusinessId = 2, Name = "Christian's Bakery", Industry = "Food & Beverage", Address = "Tualatin, Oregon", Hours = "8am-6pm, Mon-Fri" },
                new Business { BusinessId = 3, Name = "Alaska Airlines", Industry = "Retail", Address = "Newberg, Oregon", Hours = "24 Hours/Day, 7 days/week" },
                new Business { BusinessId = 4, Name = "RV's To-Go", Industry = "Hospitality", Address = "Wilsonville, Oregon", Hours = "8am-5pm, 7 days/Week" },
                new Business { BusinessId = 5, Name = "Chanel's Hair Choppin", Industry = "Retail", Address = "Wilsonville, Oregon", Hours = "8am-6pm, Mon-Thurs" }
            );
        }
    }
}