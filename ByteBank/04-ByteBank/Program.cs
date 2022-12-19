﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);
            bool resultadoSaque = contaBruno.Sacar(500);
            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaGabriela.saldo);

            Console.WriteLine("Transferencia de 200 do Bruno para Gabriela");

            bool resultadoTransferencia = contaBruno.Transferir(200, contaGabriela);

            Console.WriteLine("Saldo Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaGabriela.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            contaGabriela.Transferir(100, contaBruno);

            Console.WriteLine("Saldo Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
