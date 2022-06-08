using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
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
