using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDInBlazor.Model;

namespace CRUDInBlazor.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDInBlazor.Model.Product> Product { get; set; } = default!;
    }
}
