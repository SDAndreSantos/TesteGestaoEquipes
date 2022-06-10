using Teste_RH.Models;

namespace Teste_RH.Services
{
    public class BonificacaoService
    {
        public double GetBonus(Funcionario funcionario)
        {
            double bonus = funcionario.Salario;
            string cargo = funcionario.Cargo;
            switch (cargo)
            {
                case "Recursos Humanos":
                    bonus += (bonus * 0.05);
                    break;

                case "Gerente":
                    bonus += (bonus * 0.06);
                    break;

                case "Operador":
                    bonus += (bonus * 0.02);
                    break;

                default:
                    bonus = 0;
                    break;
            }
            return bonus;
        }
        
    }
}