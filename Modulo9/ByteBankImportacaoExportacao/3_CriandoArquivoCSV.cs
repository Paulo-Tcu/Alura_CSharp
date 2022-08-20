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
        static void CriarArquivoCSV()
        {
            var linkNovoArquivo = "C:\\Users\\paulo.cruz\\Desktop\\contasExportadas.csv";

            using(var fluxoArquivo = new FileStream(linkNovoArquivo, FileMode.OpenOrCreate))
            using(var write = new StreamWriter(fluxoArquivo))
            {
                write.Write("123,456,100.10,Paulo2");
            }
        }

        static void TesteEscritaImediata()
        {
            var arquivo = new FileStream("C:\\Users\\paulo.cruz\\Desktop\\Teste Escrita.csv", FileMode.OpenOrCreate);

            using (arquivo)
            using (var escritor = new StreamWriter(arquivo))
            {
                for (int i = 0; i < 1000; i++)
                {
                    escritor.WriteLine($"Escrevendo linha {i+1}");
                    escritor.Flush(); //Método Flush faz com que o app chame o S.O e escreva no arquivo de imediado (Muito usado em Logs)
                    Console.WriteLine($"A linha {i+1} foi escrita no arquivo");
                    Console.ReadLine();
                }
            }
        }
    }
}