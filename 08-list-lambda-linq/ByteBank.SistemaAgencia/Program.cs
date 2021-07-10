using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new List<int>();
            idades.AdicionarVarios<int>(1, 5, 14, -25, 38, 61, 17, -1005);

            idades.Sort();

            foreach (var idade in idades)
            {
                Console.WriteLine(idade);
            }

            Console.WriteLine("-----------------------------");

            var nomes = new List<string>()
            {
                "Vinícius",
                "Gisele",
                "Mayra",
                "Vasco"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}
