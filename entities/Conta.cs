using System;
using System.Collections.Generic;
using System.Globalization;
namespace AppContaBancaria.Entities
{
    public class Conta
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public enum_tipoconta Tipo {get; set;}
        public Correntista correntista {get;set;}
        public List<Movimento> Movimentos {get;set;}
        public double Saldo {get;private set;}
        public Conta ()
        {
            correntista = new Correntista();
            Movimentos  = new List<Movimento>(); 
        }

        public void AdicionarMovimento(Movimento m)
        {
            Movimentos.Add(m);
            Saldo = Saldo + m.Credito - m.Debito;
        }

        public override string ToString()
        {
            return "Banco: " + Banco + 
            " Agencia: " + Agencia + 
            " Conta: " + NumeroConta +
            " Correntista: " + correntista.Nome + 
            " CPF: Correntista: " + correntista.Cpf + 
            " Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            
        }

    }
}