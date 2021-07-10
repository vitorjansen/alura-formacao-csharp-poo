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
            var arquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024];

            var quantidadeBytesLidos = -1;
            while (quantidadeBytesLidos != 0)
            {
                quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadKey();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var encoding = new UTF8Encoding();
            var texto = encoding.GetString(buffer);

            Console.Write(texto);
        }
    }
} 
 