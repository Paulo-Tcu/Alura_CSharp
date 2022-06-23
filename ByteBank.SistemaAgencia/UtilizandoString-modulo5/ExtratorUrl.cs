using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoString_modulo5
{
    public class ExtratorUrl
    {

        private readonly string _argumentos;
        public string Url { get; }

        public ExtratorUrl(string url)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
            {
                throw new Exception(nameof(url));
            }

            int indiceInterrogacao = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogacao+1);
            Url = url;
        }
        public string GetValor(string valor)
        {
           valor += "=";
            return _argumentos.Substring(_argumentos.IndexOf(valor) + valor.Length);
        }
        
    }
}
