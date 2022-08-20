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
            var linkNovoArquivo = "c:/users/pcara/desktop/contasExportadas.csv";

            using(var fluxoArquivo = new FileStream(linkNovoArquivo, FileMode.OpenOrCreate))
            using(var write = new StreamWriter(fluxoArquivo))
            {
                write.Write("123,456,100.10,Paulo2");
            }
        }
    }
}