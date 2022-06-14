using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo5.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000.00,cpf)
        {

        }

        public override double GetBonificacao()
        {

            return Salario *= 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
    }
}
