using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            //Caminho do arquivo, que no caso está no mesmo diretório do exe da aplicação
            var enderecoArquivo = "contas.txt";
            //Abrindo o arquivo
            var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open);

            //Criando um buffer na memória RAM e o reutilizando com o retorno dos bytes
            var buffer = new byte[1024]; //1kb
            var numeroDeBytesLidos = -1;
            
            //Um arquivo só chega ao seu final quando o método Read retornar 0
            while(numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
            

            
            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer)
        {
            foreach (byte b in buffer)
            {
                Console.Write($"{b} ");
            }
        }
    }
} 
 