using System;
using ByteBank.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string texto = "Meu número é: 2342-3453";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);

            Console.ReadLine();
        }
    }
}
