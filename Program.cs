using System;
using Appcontabancaria.entities;

namespace Appcontabancaria.entities
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Informe os dados do Correntista");
            Console.Write("Informe o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();

            Correntista c = new Correntista(nome, cpf);

            Console.Clear();
            Console.WriteLine("Correntista: " + c.Nome);
            Console.WriteLine("CPF: " + c.Cpf);
            Console.ReadLine();*/
           Conta c = new Conta();
           c.Banco = "Banco do Brasil";
           c.NumeroConta="10.10.110";
           
           
           Console.WriteLine(c.ToString());
           Console.ReadLine();
            
        
            
        }
    }
}
