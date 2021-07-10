using System;
using ByteBank.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');

            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
