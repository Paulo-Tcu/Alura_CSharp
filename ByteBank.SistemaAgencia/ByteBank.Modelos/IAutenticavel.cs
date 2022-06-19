using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public interface IAutenticavel
    {
        object Nome { get; }

        bool Autenticar(string senha);
    }
}
