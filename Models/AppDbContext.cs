using SmartTask.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace SmartTask.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("SmartTaskDb")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
