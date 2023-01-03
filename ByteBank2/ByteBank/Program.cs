using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos " + carlos.Salario);

            Console.WriteLine("Total de Funcionarios: {0}", Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            //Funcionario pedro = new Diretor();

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

            Console.WriteLine("Total de Funcionarios: {0}", Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
