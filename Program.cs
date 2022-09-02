using System;
//Permite a visulaização do Name Spece Entities onde 
//Estão as classes
using AppContaBancaria.Entities;
namespace AppContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            int itemmeu = 0;
            while (itemmeu != 6)
            {
                switch (itemmeu)
                {
                    case 0:
                        Tela.Menu();
                        itemmeu = int.Parse(System.Console.ReadLine());
                        break;
                    case 1:
                        break;
                    case 2:
                        Tela.EditarConta(conta);
                        itemmeu = 0;
                        break;
                    case 3:
                        Tela.InformacaoConta(conta);
                        itemmeu = 0;
                        break;
                    case 4:
                        Movimento mov = Tela.NovoMovimento();
                        conta.AdicionarMovimento(mov);
                        System.Console.Write("Informar uma nova movimentação? S-Sim e N-Não: ");
                        string NovoMovimento = System.Console.ReadLine();
                        if (NovoMovimento == "S")
                        {
                            itemmeu = 4;
                        }
                        else
                        {
                            itemmeu = 0;
                        }
                        break;
                    case 5:
                        Tela.ExtratoConta(conta);
                        System.Console.ReadLine();
                        itemmeu = 0;
                        break;
                }
            }
        }
    }
}
