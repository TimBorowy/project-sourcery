using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sourcery.Data
{
    public class SourceryContext : IdentityDbContext
    {
        public SourceryContext(DbContextOptions<SourceryContext> options)
            : base(options)
        {
        }

        public DbSet<Sourcery.Models.Link> Link { get; set; }

        public DbSet<Sourcery.Models.Tag> Tag { get; set; }

        public DbSet<Sourcery.Models.Category> Category { get; set; }

        public DbSet<Sourcery.Models.LinkTag> LinkTag { get; set; }


        public async Task<Models.Link>  GetLinkWIthCategories(int id)
        {

            return await Link.Include(t => t.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
