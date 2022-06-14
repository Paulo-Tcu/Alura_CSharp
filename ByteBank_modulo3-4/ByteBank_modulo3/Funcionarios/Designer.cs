using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000.00, cpf)
        {

        }

        public override double GetBonificacao()
        {

            return Salario *= 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
