using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobQ
{
    public class JobQContext: DbContext
    {
        
        public DbSet<Job> Job { get; set; }
        public DbSet<Machine> Machine { get; set; }

    }
}
