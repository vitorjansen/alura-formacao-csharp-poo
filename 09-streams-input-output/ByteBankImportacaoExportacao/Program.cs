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

            CriarArquivoComStreamWriter();

            Console.ReadKey();
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
 