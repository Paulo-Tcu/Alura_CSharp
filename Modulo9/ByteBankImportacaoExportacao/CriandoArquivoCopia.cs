using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriandoCopiaArquivo()
        {
            var arquivoOriginal = new FileStream("c:/users/pcara/desktop/teste.txt", FileMode.Open);
            var arquivoNovo = new FileStream("c:/users/pcara/desktop/teste_copia.txt", FileMode.Create);
            var buffer = new byte[1024];

            using (arquivoOriginal)
            using (arquivoNovo)
            {
                var bytesLidos = -1;
                while (bytesLidos != 0)
                {
                    bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                    arquivoNovo.Write(buffer, 0, bytesLidos);
                }
                var rodape = Encoding.UTF8.GetBytes("\n\nEste documento é uma cópia do original");
                arquivoNovo.Write(rodape, 0, rodape.Length);
            }
        }
    }
}