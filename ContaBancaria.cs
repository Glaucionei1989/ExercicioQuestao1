using System;
using System.Drawing;
using System.Globalization;

namespace Questao1
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double DepositoInicial { get; set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial)
        {
            Numero = numero;
            Titular = titular;
            DepositoInicial = depositoInicial;
        }

        internal void Deposito(double quantia)
        {
            if (quantia > 0)
                DepositoInicial += quantia;
            else
                Console.WriteLine("Valor inválido para depósito.");
            
        }

        internal void Saque(double quantia)
        {
            if (quantia > 0 && quantia <= DepositoInicial)
                DepositoInicial -= (quantia + 3.50);
            else
                Console.WriteLine("Valor inválido para saque ou saldo insuficiente.");
            
        }

        internal void Update(string titular)
        {
            Titular = titular;
        }
    }
}
