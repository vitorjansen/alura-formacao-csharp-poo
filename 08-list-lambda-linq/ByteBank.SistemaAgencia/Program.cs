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
            List<int> idades = new List<int>();
            idades.AdicionarVarios<int>(1, 5, 14, 25, 38, 61);

            //O tipo não precisa ser necessariamente preenchido na chamada pois é inferido pelo compilador.
            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Adoniran", "Jimi Hendrix");

            Console.ReadLine();
        }
    }
}
