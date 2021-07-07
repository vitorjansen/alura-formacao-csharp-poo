# 2. Herança 

### Sobrecarga

A sobrecarga é uma forma de sobreescrever um método ou propriedade adicionando novas regras de negócio a ele.

> Obs.: Não é possível sobrecarga em campos da classe.

```c#
//Sobrecarga de método: PERMITIDO
public class Base
{
    public virtual void M() { … }
}
public class Derivada : Base
{
    public override void M() { … }
}
```
```c#
//Sobrecarga de campo: INCORRETO
public class Base
{
    public virtual int numero;
}
public class Derivada : Base
{
    public override int numero;
}
```
```C#
/*
* Sobrecarga de propriedade: PERMITIDO
* Os métodos get e set são expandidos para permitirem a inclusão das novas regras de negócio
*/
public class Base
{
    public virtual int Numero { get; set; }
}
public class Derivada : Base
{
    public override int Numero 
    {  
        get
        {
            // Esse get é diferente
            // pode vir de um cache, do banco de dados, ou outro lugar.
        }
        set
        {
            // Esse set é diferente
            // pode criar um log, executar uma verificação, ou lançar um erro.
        }
    }
}
```
***

# 3. Construtores e protrected

### Constutores nas classes que possuem herança

Assim como os métodos e propriedades, as classes derivadas também herdam os construtores. Caso já haja um construtor nela, então os dois construtores serão executados, sendo o primeiro da classe pai e em seguida o da classe filha.

# 5. Interfaces

### Resolvendo o problema da heraça múltipla

Herança múltipla não existe em C#. Este problema é contornado usando interfaces.

