using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensao
    {
        public static void AddVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T i in itens)
            {
                lista.Add(i);
            }
        }
    }
}
