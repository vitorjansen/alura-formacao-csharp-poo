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
            int[] idades = new int[] { 15, 28, 35, 50, 28 };

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
                Console.WriteLine($"Valor no índice {indice}: {idades[indice]}");

            }
            int media = acumulador / idades.Length;
            Console.WriteLine(media);

            Console.ReadLine();
        }
    }
}
