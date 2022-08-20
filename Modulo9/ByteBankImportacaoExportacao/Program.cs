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
        static void Main(string[] args)
        {
            //CriarArquivoCSV();
            //Console.WriteLine("Arquivo Criado com Sucesso");

            //Console.ReadLine();
            //CriandoCopiaArquivo();
            //TesteEscritaImediata();
            //EscrevendoEmBinary();

            //Metodos auxiliares da Classe File
            var linhas = File.ReadAllLines("contas.txt");//AllLines retornar um array de string com todo conteúdo do File
            Console.WriteLine(linhas.Length);
            foreach( var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            var bytesArquivo = File.ReadAllBytes("contas.txt"); //AllBytes retorna um array de Bytes com todo conteúdo do File
            Console.WriteLine($"Arquivo contas.txt possui{bytesArquivo.Length} bytes");

            var path = "C:\\Users\\paulo.cruz\\Desktop\\escrevendoComAClasseFile.txt";
            File.WriteAllText(path, "Testando File.WriteAllText"); //AllText escreve no File, recebenco como parâmetros o arquivo para escrever
                                                                                             // e conteúdo para escrita.
            Console.WriteLine("Arquivo criado!");




            Console.ReadLine();
        }
    }
}





    




 