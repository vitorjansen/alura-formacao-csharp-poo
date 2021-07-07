using System;

namespace A05_LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            //LacoWhile();
            //LacoFor();
            LacoForEncadeado();            
        }

        private static void LacoWhile()
        {
            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                contadorMes += 1;
            }
        }

        private static void LacoFor()
        {
            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine(
                    "Após " + contadorMes +
                    " meses, você terá R$" + valorInvestido);
            }
        }

        private static void LacoForEncadeado()
        {
            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
        }
    }
}
