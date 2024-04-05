using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalc { get; set; }
        public int Calcular()
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }
        public string Calcular2()
        {
            string resultado = "";
            AreaCalc = Base * Altura;

            if (Base==Altura) 
            {
                resultado = "Quadrado de área " + AreaCalc;
            }
            else 
            {
                resultado = "Retangulo de área " + AreaCalc;
            }

            return resultado;
        }
        public void Calcular3() 
        {
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Atura: " + Altura);
            Console.WriteLine("Área: " + AreaCalc);
        }
    }
}
