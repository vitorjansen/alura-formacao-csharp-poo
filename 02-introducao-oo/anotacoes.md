# 2. Tipos

### Tipos de referência X Tipos de valor

#### Tipos de valor
São as variáveis que armazenam diretamente um determinado valor.

#### Tipos de referência
São as variáveis que armazenam o "endereço" do objeto na memória

#### Principal diferença
Variáveis de valor só podem ter seus valores alterados diretamentes. Por outro lado, se duas vaiáveis apotam para a mesma referência, quando o valor é alterado por uma delas a outra também sofre alteração indiretamente.

***

# 5. Propriedades

#### Adicionando validações em métodos get e set

Uma propriedade com métodos get e set costuma ser escrita desta maneira:

```c#
public string CPF { get; set; }
```

Para adiconar alguma validação a estes métodos podemos expandí-los e incrementar o código conforme abaixo, adicionando uma variável privada para receber a validação: 


```c#
private string _cpf;
public string CPF
{
    get
    {
        return _cpf;
    }
    set;
    {
        // Lógica de validação de CPF
        _cpf = value;
    }
}
```

***