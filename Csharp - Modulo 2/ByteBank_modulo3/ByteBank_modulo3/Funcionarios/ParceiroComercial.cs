using ByteBank_modulo3.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3.Funcionarios
{
    public class ParceiroComercial : Autenticavel
    {
        private string _senha;
        public string Nome { get; set; }
               public string Senha
        {
            get { return _senha; }
            set
            {
                if (value != _senha || value.Length > 0)
                {
                    _senha = value;
                }
                else
                {
                    Console.WriteLine("Nova senha inválida !!!");
                    return;
                }
            }

        }

        object Autenticavel.Nome
        {
            get { return Nome; }
        }

        public bool Autenticar(string senha)
        {

            return _senha == senha;
        }
    }
}
