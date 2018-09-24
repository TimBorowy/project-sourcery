using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sourcery.Models
{
    public class SourceryContext : DbContext
    {
        public SourceryContext (DbContextOptions<SourceryContext> options)
            : base(options)
        {
        }

        public DbSet<Sourcery.Models.Link> Link { get; set; }
    }
}
