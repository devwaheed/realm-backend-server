using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace realm_backend_server
{
    public class RBSContext : DbContext
    {
        public RBSContext(DbContextOptions<RBSContext> options): base(options)
        {
        }

        public DbSet<RemTask> Tasks { get; set; }
    }
}
