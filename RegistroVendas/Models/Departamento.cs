using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroVendas.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //Implementação da associação entre a classe Departamento e Vendedor
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        //Construtor sem argumentos
        public Departamento()
        {

        }
        //Construtor com argumentos
        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
