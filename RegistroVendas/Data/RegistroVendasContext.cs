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

        //Adição do DbSet da classe 'Departamento'
        public DbSet<RegistroVendas.Models.Departamento> Departamento { get; set; }

        //Adição do DbSet da classe 'Vendedor'
        public DbSet<RegistroVendas.Models.Vendedor> Vendedor { get; set; }

        //Adição do DbSet da classe 'Vendas'
        public DbSet<RegistroVendas.Models.Vendas> Vendas { get; set; }
    }
}



