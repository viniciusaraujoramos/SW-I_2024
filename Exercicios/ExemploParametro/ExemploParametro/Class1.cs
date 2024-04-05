using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    public class Escolhas
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalc { get; set; }
        public int AreaTri { get; set; }

        public void Escolha(int opcao) 
        {
            if (opcao ==1)
            {
                float quadrado = qua();
                Console.WriteLine("A área do quadrado é: " + quadrado);
            }
            else if (opcao ==2) 
            {
                float retangulo = ret();
                Console.WriteLine("A área do quadrado é: " + retangulo);

            }
            else if(opcao ==3)
            {
                float triangulo = tri();
                Console.WriteLine("A área do quadrado é: " + triangulo);
            }
        }

        public float qua() 
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }
        public float ret()
        {
            AreaCalc = Base * Altura;
            return AreaCalc;
        }
        public float tri()
        {
            AreaTri = Base * Altura/2;
            return AreaTri;
        }
    }
}
