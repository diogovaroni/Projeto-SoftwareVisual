using RegistroVendas.Data;
using RegistroVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroVendas.Services
{
    public class VendedorService
    {
        private readonly RegistroVendasContext _context;
        public VendedorService(RegistroVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}
