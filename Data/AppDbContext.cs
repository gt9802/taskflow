using Microsoft.EntityFrameworkCore;
using TaskFLow.Models;

namespace TaskFLow.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) { 
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
