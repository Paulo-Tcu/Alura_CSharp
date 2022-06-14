using ByteBank_modulo3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3.Sistemas
{
    public class SistemaInterno
    {
        public static bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem vindo ao sistema {funcionario.Nome}");
                return true;
            }
            else
            {
                Console.WriteLine($"Senha incorreta !!!");
                return false;
            }
        }
    }
}
