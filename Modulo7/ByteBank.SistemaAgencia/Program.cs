using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ////criando array
            //int[] idades = new int[5]; //Define o tipo do array e seu tamanho

            //idades[0] = 15;
            //idades[1] = 28;
            //idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //// caso não for definido o valor para o indice o compilador incrementa 0 no tipo int

            //int[] novoArray = new int[5];
            //novoArray[0] = idades[0];

            //idades[0] = 20;
            //Console.WriteLine(novoArray[0]); // ao passar valor de outro array, o mesmo é feito por valor e não referencia

            //for(int i = 0,media=0; i < idades.Length; i++)
            //{
            //    media += idades[i];
            //    if(i == idades.Length)
            //    {
            //        Console.WriteLine($"O valor da média é de: {media/idades.Length}");
            //    }
            //}

            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*Array com objs-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

            //ContaCorrente[] contas = new ContaCorrente[]
            //{
            //    new ContaCorrente(874, 5679787),
            //    new ContaCorrente(874, 4456668),
            //    new ContaCorrente(874, 7781438),
            //};

            //for (int indice = 0; indice < contas.Length; indice++)
            //{
            //    ContaCorrente contaAtual = contas[indice];
            //    Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            //}
            //Console.ReadLine();

            Lista<ContaCorrente> lista = new Lista<ContaCorrente>();

            ContaCorrente contaPaulo = new ContaCorrente(1000, 2000);
            lista.Adicionar(contaPaulo);
            lista.Adicionar(new ContaCorrente(10,20));
            lista.Adicionar(new ContaCorrente(10,20));
            lista.Adicionar(new ContaCorrente(10,20));
            lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));
            //lista.Adicionar(new ContaCorrente(10,20));

            //lista.GetPrintFullLista();
            //Console.WriteLine("Depois de remover um item do array");
            //lista.Remover(contaPaulo);
            //lista.GetPrintFullLista();
            Console.WriteLine($"O número da conta é {lista[0].Numero} e agência é {lista[0].Agencia}");
            lista.Adicionar(new ContaCorrente(10, 1), new ContaCorrente(10, 2), new ContaCorrente(10, 3));

            for(int i=0; i < lista.ProximoIndice; i++)
            {
                Console.WriteLine($"No indice {i} o numero da agência é: {lista[i].Agencia}, já o numero de conta é: {lista[i].Numero}");
                if (lista[i] == null) break;
            }

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(10, 20, 30,40,50,60);
            //idades.GetPrintFullLista();
            Console.ReadLine();
        }
    }
}
