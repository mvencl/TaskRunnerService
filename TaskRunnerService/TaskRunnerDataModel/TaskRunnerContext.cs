using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TaskRunnerDataModel
{
    public class TaskRunnerContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
