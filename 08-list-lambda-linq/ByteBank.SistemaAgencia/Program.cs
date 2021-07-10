using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJose = null;

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 48950),
                contaDoJose,
                new ContaCorrente(290, 18950)
            };

            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                if (conta == null)
                    Console.WriteLine("Conta sem atribuição");
                else
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }
    }
}
