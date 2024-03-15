using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        private string? Num_conta { get; set; }
        private double Saldo { get; set; }
        private double Limite { get; set; }

        public void Consulta_saldo()
        {   
            Console.WriteLine("Você está consultando seu saldo: seu saldo atual é de R$ " + Saldo);
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Você vai depositar: " +valor);
            Saldo = Saldo + valor;
        }

        public void Sacar(double valor)
        {
            Console.WriteLine("Você irá sacar: " + valor);
            if (valor <= Saldo + Limite)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }

        public void Ajuste_limite(double valor)
        {
            Limite = valor;
        }
    }
}
