using System;

namespace A02_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe 1 para criação de variáveis: tipo + nome
            int nomeVariavel;

            //Sintaxe 2 para criação de variáveis: tipo + nome + atribuição
            string nomeCliente = "João";

            //Referência dos tipos de dados em C#
            //http://www.linhadecodigo.com.br/artigo/12/tipos-de-dados-no-net.aspx



            //CriandoVariaveis();
            //TestaPontoFlutuante();
            ConversoesDeTipos();
        }

        private static void CriandoVariaveis()
        {
            int idade = 37;
            Console.WriteLine("A idade é: " + idade);
        }

        private static void TestaPontoFlutuante()
        {
            double salario = 1275.70;
            Console.WriteLine("Meu salario é " + salario);

            //É importante notar que divisões com números inteiros resultam em números inteiros.
            //Independente de o tipo da váriavel ou o resultado ser double.
            double divisao = 5 / 2;
            Console.WriteLine(divisao);

            divisao = 5.0 / 2;
            Console.WriteLine(divisao);
        }

        private static void ConversoesDeTipos()
        {
            //Casting: É o modo de informar ao compilador que há uma mudança no tipo de dado.

            double salario = 1200.50;
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);
            Console.WriteLine();

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);
            Console.WriteLine();

            //A diferença de double e float é que o primeiro é mais preciso nas casas decimais.
            //Float deve ser usado com o f no final para diferenciá-lo do double
            float pontoFlutuante = 3.14f;
            Console.WriteLine(pontoFlutuante);

        }
    }
}
