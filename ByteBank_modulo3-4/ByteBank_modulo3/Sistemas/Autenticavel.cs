using ByteBank_modulo3.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_modulo3.Sistemas
{ 
    public interface Autenticavel
    {
        object Nome { get; }

        bool Autenticar(string senha);
    }
}
