using System;
using AppContaBancaria.Entities;
using System.Globalization;
namespace AppContaBancaria
{
    class Tela
    {
        
        public static void Menu()
        {
            System.Console.Clear();
            System.Console.WriteLine("|===============================|");
            System.Console.WriteLine("|           MENU                |");
            System.Console.WriteLine("|===============================|");
            System.Console.WriteLine("|1 - Carregar Conta             |");
            System.Console.WriteLine("|2 - Editar Conta               |");
            System.Console.WriteLine("|3 - Informações da conta       |");
            System.Console.WriteLine("|4 - Registra movimento         |");
            System.Console.WriteLine("|5 - Extrado da conta           |");
            System.Console.WriteLine("|6 - Sair                       |");
            System.Console.WriteLine("|===============================|");
        }
        public static void EditarConta(Conta c)
        {
            System.Console.Clear();
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("|         INFORME OS DADOS DA CONTA         |");
            System.Console.WriteLine("---------------------------------------------");
            System.Console.Write("Informe o nome do banco: ");
            string banco = System.Console.ReadLine();
            System.Console.Write("Informe o número da Agencia: ");
            string agencia = System.Console.ReadLine();
            System.Console.Write("Informe o número da conta: ");
            string conta = System.Console.ReadLine();
            System.Console.Write("Informe o nome da correntista: ");
            string CorrentistaNome = System.Console.ReadLine();
            System.Console.Write("Informe o cpf da correntista: ");
            string CorrentistaCPF = System.Console.ReadLine();

            c.Banco = banco;
            c.Agencia = agencia;
            c.NumeroConta = conta;
            c.correntista.Nome = CorrentistaNome;
            c.correntista.Cpf = CorrentistaCPF;

            System.Console.WriteLine("Informações gravadas com sucesso!");
            System.Console.ReadLine();
        }
        public static void InformacaoConta(Conta c)
        {
            System.Console.Clear();
            System.Console.WriteLine("|===============================|");
            System.Console.WriteLine("Banco: " + c.Banco);
            System.Console.WriteLine("Agencia: " + c.Agencia);
            System.Console.WriteLine("Conta: " + c.NumeroConta);
            System.Console.WriteLine("Titular: " + c.correntista.Nome);
            System.Console.WriteLine("CPF Titular: " + c.correntista.Cpf);
            System.Console.WriteLine("Saldo da conta: " + c.Saldo.ToString("F2"));
            System.Console.ReadLine( );
        }
        public static Movimento NovoMovimento()
        {
            Movimento mov = new Movimento();
           //Incluir dados da conta
            System.Console.Clear();
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("|     INFORME UMA MOVIMENTAÇÃO DA CONTA      |");
            System.Console.WriteLine("---------------------------------------------");          
            System.Console.Write("Informe C para crédito D para débito: ");
            string Tipo = System.Console.ReadLine();
            System.Console.Write("Informe a data da movimentação: ");
            mov.Data = DateTime.Parse(System.Console.ReadLine());
            System.Console.Write("Informe a descrição da movimentação: ");
            mov.Descricao = System.Console.ReadLine();
            mov.Credito = 0;
            mov.Debito = 0;
            if (Tipo == "C")
            {
                System.Console.Write("Informe o crédito: ");
                mov.Credito = double.Parse(System.Console.ReadLine());
            }            
            else
            {
                System.Console.Write("Informe o débito: ");
                mov.Debito = double.Parse(System.Console.ReadLine());

            }

            return mov;
        }
        public static void ExtratoConta(Conta c)
        {
            System.Console.Clear();
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine("|           EXTRATO DE CONTA                |");
            System.Console.WriteLine("---------------------------------------------");          

            foreach (Movimento mov in c.Movimentos)
            {
                System.Console.WriteLine(mov.ToString());
            }

        }
    }
}