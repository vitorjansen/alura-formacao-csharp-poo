using System;

namespace A01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente(876, 123456);
            primeiraContaCorrente.Saldo = 200;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Saldo += 100;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente(985, 987654);
            segundaContaCorrente.Saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.Saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.Saldo);
            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
        }
    }
}
