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
            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            Console.WriteLine(extrator.GetValor("moedaOrigem"));  // real
            Console.WriteLine(extrator.GetValor("moedaDestino")); // dolar
            Console.WriteLine(extrator.GetValor("valor")); // 1500

            Console.ReadLine();
        }
    }
}
