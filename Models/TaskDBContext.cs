//using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
namespace lll.Models
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options)
            : base(options) { }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }


    }
}
