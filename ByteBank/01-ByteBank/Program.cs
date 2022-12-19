using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular = "Gabriela";
            int numeroAgencia = 863;
            int numeroConta = 863146;
            double saldo = 100;

            string titular2 = "Bruno";
            int numeroAgencia2 = 863;
            int numeroConta2 = 863146;
            double saldo2 = 100;

            new ContaCorrente();

            Console.ReadLine();
        }
    }
}
