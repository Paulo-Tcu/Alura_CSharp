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
            List<int> idades = new List<int>();
            idades.Add(10);
            idades.Add(20);
            idades.Add(30);
            idades.Add(40);

            idades.AddVarios(50, 60, 70, 80);

            idades.Remove(10);

            for(int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
            idades.RemoveAt(1);
            Console.WriteLine();
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
            Console.ReadLine();
        }
    }
}
