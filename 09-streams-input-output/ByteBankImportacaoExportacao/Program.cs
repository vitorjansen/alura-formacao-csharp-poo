using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            //StreamDaConsole();
            AuxiliaresDaclasseFile();

            Console.ReadKey();
        }

        private static void AuxiliaresDaclasseFile()
        {
            // Os exemplos abaixos são abstrações do métodos de leitura e escrita em arquivos.
            // Com não podem ser configurados devem ser utilizados apenas em arquivos pequenos.
            // Assim, não há problema na memória.

            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);
        }

        static void StreamDaConsole()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; // 1 kb

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();

                    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                }
            }

            // O código abaixo é uma abstração/simplicação do código acima

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}");

        }

        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); // Número da Agência
                escritor.Write(546544); // Número da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Gustavo Braga");

            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }

        static void EscritaComFlush()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    // O método Flush despeja o conteudo do buffer no arquivo.
                    // Consequentemente o arquivo será preenchido conforme execução e não apenas no final.
                    escritor.Flush();
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }

        static void CriarArquivoComStreamWriter()
        {
            /* 
             * FileMode.Create x FileMode.CreateNew
             * 1. FileMode.Create: Cria o arquivo se não existir.
             *                      Caso exista, apaga todo o conteúdo para ser utilizado do "zero".
             * 2. FileMode.CreateNew:  Cria o arquivo se não existir.
             *                          Caso exista, lança uma exceção.
            */

            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456,65465,456.0,Pedro");
            }
        }

        static void LeituraDeArquivoEConversaoParaClasse()
        {
            var caminhoArquivo = "contas.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo, Encoding.UTF8))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                }
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
} 
 