using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Clientes
{
    public class Cliente
    {
        public string primeiro_nome;
        public string sobrenome;
        public string cpf;
        public string profissao;

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;

           if (outroCliente == null)
            {
                return false;
            }

            return cpf == outroCliente.cpf;
        }
    }
}
