using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo5.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000.00, cpf)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.30;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.20;
        }
    }
}
