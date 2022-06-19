using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
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

        object IAutenticavel.Nome
        {
            get { return Nome; }
        }

        public bool Autenticar(string senha)
        {

            return AutenticadorHelper.CompararSenhas(Senha, senha);
        }
    }
}
