using System;

namespace Appcontabancaria.entities
{
    public class Correntista
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public override string ToString()
        {
            return "Nome: " + Nome + " Cpf:" + Cpf;
        }

        
    }
}