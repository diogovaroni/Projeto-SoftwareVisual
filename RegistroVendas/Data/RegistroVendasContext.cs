using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroVendas.Models;

namespace RegistroVendas.Data
{
    public class RegistroVendasContext : DbContext
    {
        public RegistroVendasContext (DbContextOptions<RegistroVendasContext> options)
            : base(options)
        {
        }

        public DbSet<RegistroVendas.Models.Departamento> Departamento { get; set; }
    }
}
