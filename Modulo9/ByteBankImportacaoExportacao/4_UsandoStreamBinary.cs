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
        static void EscrevendoEmBinary()
        {
            var arquivo = new FileStream("C:\\Users\\paulo.cruz\\Desktop\\Teste em Binary.txt",FileMode.Create);

            using (arquivo)
            using (var escritor = new BinaryWriter(arquivo))
            {
                escritor.Write(456); // Número da Agência
                escritor.Write(546544); // Número da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Paulo Cesar");
            }
            LendoEmBinary();
        }

        static void LendoEmBinary()
        {
            var arquivo = new FileStream("C:\\Users\\paulo.cruz\\Desktop\\Teste em Binary.txt", FileMode.Open);
            using (arquivo)
            using (var leitor = new BinaryReader(arquivo))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Ag: {agencia}\nConta: {numeroConta}\nSaldo: {saldo}\nTitular: {titular}");
            }
        }
    }
}
