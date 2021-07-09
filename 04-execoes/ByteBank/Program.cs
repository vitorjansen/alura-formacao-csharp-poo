using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 456478);

                //conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }

            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
