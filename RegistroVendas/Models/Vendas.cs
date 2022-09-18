using RegistroVendas.Models.Enums;
using System;


namespace RegistroVendas.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double Valor { get; set; }
        public VendaStatus Status { get; set; }

        //Associação da classe RegistroVendas com a classe Vendedor
        public Vendedor Vendedor { get; set; }

        //Construtor sem argumentos
        public Vendas()
        {

        }
        //Construtor com argumentos
        public Vendas(int id, DateTime dataVenda, double valor,
            VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
