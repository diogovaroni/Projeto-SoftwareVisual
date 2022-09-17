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

        //Associação da classe Vendedor com a classe Departamento
        public Departamento Departamento { get; set; }

        //Implementação da associação entre a classe Vendedor e RegistroVendas
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        //Construtor sem argumentos
        public Vendedor()
        {

        }
        //Construtor com argumentos
        public Vendedor(int id, string nome, string email, string cPF,
            double baseSalarial, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cPF;
            BaseSalarial = baseSalarial;
            Departamento = departamento;            
        }
    }
}




