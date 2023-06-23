using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF1.Models;

namespace EF1.Data
{
    public class EF1Context : DbContext
    {
        public EF1Context (DbContextOptions<EF1Context> options)
            : base(options)
        {
        }

        public DbSet<EF1.Models.Clients> Clients { get; set; } = default!;
    }
}
