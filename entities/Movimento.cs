using System;
using System.Globalization;
namespace AppContaBancaria.Entities
{
    public class Movimento
    {
        public DateTime Data {get;set;}
        public string Descricao {get; set;}
        public double Credito {get; set;}
        public double Debito {get;set;}
        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") 
            + "|" + Descricao 
            + "|" + Credito.ToString("F2", CultureInfo.InvariantCulture) 
            + "|" + Debito.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}