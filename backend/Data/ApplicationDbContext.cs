using Microsoft.EntityFrameworkCore;
using FinalExamSimulation.Models;

namespace FinalExamSimulation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}