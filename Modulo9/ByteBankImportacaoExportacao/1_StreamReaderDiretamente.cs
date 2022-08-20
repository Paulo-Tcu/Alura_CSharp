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
        static void LidandoComFileStreamDiretamente_Jeito1DaAula()
        {
            //Caminho do arquivo, que no caso está no mesmo diretório do exe da aplicação
            var enderecoArquivo = "contas.txt";
            //Abrindo o arquivo

            using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                //Criando um buffer na memória RAM e o reutilizando com o retorno dos bytes
                var buffer = new byte[1024]; //1kb
                var numeroDeBytesLidos = -1;

                //Um arquivo só chega ao seu final quando o método Read retornar 0
                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
                //Não houve a necessidade de chamar o método Close pois a interfaxe IDisposable já trata no using
                //fluxoDoArquivo.Close();
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            //var utf8 = Encoding.UTF8;
            var utf8 = Encoding.Default; // o default pega o mesmo tipo do SO e utiliza para decodificação
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            //foreach (byte b in buffer)
            //{
            //    Console.Write($"{b} ");
            //}
        }
    }
}