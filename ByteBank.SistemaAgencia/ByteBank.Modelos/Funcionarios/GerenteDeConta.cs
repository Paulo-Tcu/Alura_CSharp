using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        private string _senha;
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }
        public override double GetBonificacao()
        {

            return Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

    }
}
