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
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

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

        //Método para adicionar uma venda ao vendedor
        public void AdicionarVenda(Vendas v)
        {
            Vendas.Add(v);
        }

        //Método para remover uma venda do vendedor
        public void RemoverVenda(Vendas v)
        {
            Vendas.Remove(v);
        }

        //Método para retornar o total de vendas do vendedor
        public double TotalVendas(DateTime inicial, DateTime final) 
        {
            return Vendas.Where(v => v.DataVenda >= inicial && v.DataVenda <= final).Sum(v => v.Valor);
        }

    }
}




