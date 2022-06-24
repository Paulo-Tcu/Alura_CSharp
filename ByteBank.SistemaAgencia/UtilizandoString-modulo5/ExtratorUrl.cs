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

            url = url.ToLower();
            _argumentos = url.Substring(url.IndexOf("?") + 1);
            Url = url;
        }
        public string GetValor(string valor)
        {
           valor += "=";
            string resultado = _argumentos.Substring(_argumentos.IndexOf(valor) + valor.Length);
            if(resultado.IndexOf("?") != -1)
            {
                return resultado.Remove(resultado.IndexOf("?"));
            }
            return resultado;
        }
        
    }
}
