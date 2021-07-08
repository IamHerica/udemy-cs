using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; } // private pq não pode mudar 
        public string Titular { get; set; }
        public double Saldo { get; private set; } //encapsulamento

        //construido pelo pincel do lado
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) //indicando que os argumentos são os da classe
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0; //taxa de saque
        }

        public override string ToString() //para formatar o texto de saída bonitinho
        {
            return "Conta" +
                Numero +
                ", Titular: " +
                Titular +
                "Saldo: " +
                Saldo.ToString("C2", CultureInfo.InvariantCulture );
        }

        
    }
}

