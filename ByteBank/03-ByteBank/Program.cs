using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela Costa";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta) );

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2) );

            contaGabriela = contaGabrielaCosta;
            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabriela.saldo = 300;

            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}
