using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _29_06_API.Modeles;

namespace _29_06_API.Data
{
    public class _29_06_APIContext : DbContext
    {
        public _29_06_APIContext (DbContextOptions<_29_06_APIContext> options)
            : base(options)
        {
        }

        public DbSet<_29_06_API.Modeles.Produto> Produto { get; set; }
    }
}
