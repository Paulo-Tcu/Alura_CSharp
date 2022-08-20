
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
        static void UsandoStreamReader()
        {
            var enderecoArquivo = "contas.txt";

            using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo)) 
            {
                //Possível usar metodos Read: ReadToEnd executa tudo de uma única vez
                //Console.WriteLine(leitor.ReadToEnd());

                while (!leitor.EndOfStream) // metodo que retornar o final do arquivo
                {
                    var contaCorrente = ConvertendoStringParaContaCorrente(leitor.ReadLine());

                    //Console.WriteLine(leitor.ReadLine()); //metodo Read para ler linha a linha do arquivo

                    Console.WriteLine($"{contaCorrente.Titular.Nome}: número {contaCorrente.Numero}, Ag {contaCorrente.Agencia} e " +
                        $"saldo de R$ {contaCorrente.Saldo} --- Criada com sucesso");
                }
                Console.ReadLine();
            }
        }
        //Transformando o retorno do arquivo em ContaCorrente
        static ContaCorrente ConvertendoStringParaContaCorrente(string linha)
        {
            //Split para quebrar o arquivo no argumento desejado e retornar um Lista
            string[] campos = linha.Split(',');

            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace(".", ","));
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = titular;

            return resultado;
        }
    }
}