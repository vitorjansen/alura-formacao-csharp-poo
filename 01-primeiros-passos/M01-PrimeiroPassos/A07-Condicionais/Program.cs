using System;

namespace A04_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }
    }
}
