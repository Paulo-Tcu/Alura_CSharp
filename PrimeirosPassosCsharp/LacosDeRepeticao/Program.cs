// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        //for (int linha = 0; linha < 10; linha++)
        //{
        //    for (int coluna = 0; coluna < 10; coluna++)
        //    {
        //        if (coluna > linha)
        //        {
        //            break;
        //        }
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //for (int numero = 3; numero <= 100; numero += 3)
        //{
        //    Console.WriteLine(numero);
        //}
        //Console.WriteLine();
        //for(int numero = 3; numero <= 100; numero++)
        //{
        //    if (numero % 3 == 0) Console.WriteLine(numero);
        //}

        for (int numero = 1, fatorial = 1; numero <= 10; numero++)  //Desafio, laço de repetição para fatorial
        {
            fatorial *= numero;
            Console.WriteLine($"O fatorial de {numero} é {fatorial}");

        }
    }
}

