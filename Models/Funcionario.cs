namespace Teste_RH.Models
{
    public class Funcionario
    {

        public Funcionario(string primeiroNome, string ultimoNome, string dataNascimento, float salario, string cargo)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.DataNascimento = dataNascimento;
            this.Salario = salario;
            this.Cargo = cargo;
        }

        public Funcionario(){}
        public string PrimeiroNome {get; set;}

        public string UltimoNome {get; set;}

        public string DataNascimento {get; set;}

        public float Salario {get; set;}

        public string Cargo {get; set;}
    }
}