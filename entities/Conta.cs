using System;
namespace Appcontabancaria.entities
{
    public class Conta
    {
        public string Banco{get;set;}
        public string Agencia{get;set;}
        public string NumeroConta{get;set;}
        public enum_tipoconta Tipo{get;set;}
        public Correntista Correntista{get;set;}

        public override string ToString()
        {
            return "Banco:" + Banco +
            " Agencia: " + Agencia +
            " Conta: " + NumeroConta;
 
        }

    }
}