using ByteBank_modulo5.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo5.Sistemas
{ 
    public interface Autenticavel
    {
        object Nome { get; }

        bool Autenticar(string senha);
    }
}
