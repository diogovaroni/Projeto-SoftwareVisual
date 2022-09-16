using RegistroVendas.Models.Enums;
using System;


namespace RegistroVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double Valor { get; set; }
        public VendaStatus Status { get; set; }
    }
}
