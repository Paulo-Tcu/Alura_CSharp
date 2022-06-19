using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class SistemaInterno
    {
        public static bool Logar(IAutenticavel funcionario, string senha)
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
