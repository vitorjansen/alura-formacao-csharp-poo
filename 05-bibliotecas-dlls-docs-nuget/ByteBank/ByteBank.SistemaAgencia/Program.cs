using System;
using ByteBank.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(374, 3627362);
            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("key");


            Console.ReadLine();
        }
    }
}
