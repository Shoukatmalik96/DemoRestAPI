using Microsoft.EntityFrameworkCore;

namespace DemoRestAPI.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            :base(options)
        {

        }

        public DbSet<CountryItem> CountryItems { get; set; }
    }
}
