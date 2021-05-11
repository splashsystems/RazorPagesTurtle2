using Microsoft.EntityFrameworkCore;

namespace RazorPagesTurtle.Data
{
    public class RazorPagesTurtleContext : DbContext
    {
        public RazorPagesTurtleContext(
            DbContextOptions<RazorPagesTurtleContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle.Models.Turtle> Turtle { get; set; }
    }
}
