using System;

namespace A01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.Saldo = 200;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            primeiraContaCorrente.Saldo += 100;
            Console.WriteLine(primeiraContaCorrente.Saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.Saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.Saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.Saldo);
        }
    }
}
