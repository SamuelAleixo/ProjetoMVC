using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoMVC.Models.Departament> Departament { get; set; }
        public DbSet<ProjetoMVC.Models.Seller> Seller { get; set; }
        public DbSet<ProjetoMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}
