using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NuremoConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NuremoConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                System.Console.WriteLine("Valor desejado é maior que saldo disponivel");
            }

        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo disponivel é: " + saldo);
        }
    }
}