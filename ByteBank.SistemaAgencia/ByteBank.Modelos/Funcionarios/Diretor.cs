using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        private string _senha;
        public Diretor(string cpf) : base(5000.00, cpf)
        {

        }

        public override double GetBonificacao()
        {
            /* Nesse caso estamos sobrescrevendo o metodo da classe pai pelo overrride e estamos chamando o metodo da classe pai 
             pela palavra reservada base*/
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
