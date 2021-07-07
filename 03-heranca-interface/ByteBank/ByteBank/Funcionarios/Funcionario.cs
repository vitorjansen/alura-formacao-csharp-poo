using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        protected double Salario { get; set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Salario = salario;
            Cpf = cpf;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
