using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {



        public static int TotaldeFuncionarios { get; private set; } 

            public string Nome { get; set; }
            public string CPF { get; private set; }
            public double Salario { get; protected set; }
            public string Senha { get; set; }

        public Funcionario(double salario, string cpf)
            {
            Console.WriteLine("Criando Funcionário");

            Salario = salario;

            CPF = cpf;
            
            TotaldeFuncionarios++;
            }

        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
        public abstract void AumentarSalario();


        public abstract double GetBonificacao();

    }
}
