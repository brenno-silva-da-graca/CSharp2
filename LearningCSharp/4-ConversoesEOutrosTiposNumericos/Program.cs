using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversoes e outros tipos numericos");

            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);

            // O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável que suporta valores até 64 bits
            long idadeUniverso;
            idadeUniverso = 13000000000;
            Console.WriteLine(idadeUniverso);

            // O short é uma variável que suporta valores até 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
