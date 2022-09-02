//Declara a visibilidade da classe
namespace AppContaBancaria.Entities
{
    //Classe de correntista
    public class Correntista
    {
        //Atributos da Classe
        public string Nome { get; set; }
        // Public indica que o atributo é publico e pode ser
        //Visualizado na instância da classe
        //Get e Set indica que o atributo pode ser ligo
        //e escrito
        public string Cpf  { get; set; }

        public override string ToString()
        {
            return "Nome: " + Nome + " CPF: " + Cpf;
        }
    }
}