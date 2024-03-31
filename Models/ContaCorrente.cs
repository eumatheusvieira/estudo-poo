using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("SAQUE REALIZADO!");
            }
            else
            {
                Console.WriteLine("SAQUE NÃO REALIZADO!");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}");
        }
    }
}