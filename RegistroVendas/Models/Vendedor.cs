using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String CPF { get; set; }
        public double BaseSalarial { get; set; }
    }
}




