# 1. O ecossistema .NET

### Linguagens
Diversas linguagens podem ser usadas no ecossistema .NET, como por exemplo C#, VB, F# etc.

### Aplicação .NET 
Toda linguagem .NET é convertida para MSIL (Microsoft Intermidiate Language).
MSIL é uma linguagem comum (intermediária) que tem por objetivo padronizar um ambiente de execução, evitando assim que se crie uma biblioteca para cada linguagem e Sistema Operacional (SO).

### .NET Framework
É a biblioteca escrita em MSIL, comum para todo o ecossistema .NET

### CLR - Common Language Runtime (Máquina Virtual)
É o ambiente (independente do SO) que converte MSIL para linguagem de máquina e executa a aplicação.

***

# 2. Primeiro Programa e o Visual Studio

### Compilando um programa a partir de um arquivo de texto

Dentro da pasta onde está o arquivo de texto deve-se abrir o terminal e digitar o caminho do arquivo csc.exe (que é o compilador do C# para a linguagem MSIL) seguido do txt que será compilado, o resultado é um arquivo .exe que executa o código escrito.

> Exemplo:
> c:\DiretorioArquivo>c:\Windows\Microsoft.NET\Framework\v4.0.30219\csc.exe NomeArquivo.txt

***
