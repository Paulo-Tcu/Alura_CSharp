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
            var arquivoOriginal = new FileStream("C:\\Users\\paulo.cruz\\Desktop\\teste.txt", FileMode.Open);
            var arquivoNovo = new FileStream("C:\\Users\\paulo.cruz\\Desktop\\teste_copia.txt", FileMode.Create);
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
                var rodape = Encoding.UTF8.GetBytes("\n\nEste documento é uma cópia do original");//GetBytes converte num array de Bytes, já GetString converte Bytes em string
                arquivoNovo.Write(rodape, 0, rodape.Length);
            }
        }
    }
}