using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    internal class Class
    {
        private double Velocidade { get; set; }
        private double Altitude { get; set; }

        public void AumentaVel(double mais)
        {
            if (Velocidade + mais > 950)
            {
                Console.WriteLine("Você não pode acelerar tanto, pare no 950Km/h.");
            }
            else
            {
                Velocidade = Velocidade + mais;
                Console.WriteLine("Sua velociade é " + Velocidade + "Km/h");
            }
        }
        public void DiminuiVel(double menos)
        {
            if (Velocidade - menos < 0)
            {
                Console.WriteLine("Você não pode desacelerar tanto, pare no 0.");
            }
            else
            {
                Velocidade = Velocidade - menos;
                Console.WriteLine("Sua velociade é " + Velocidade + "Km/h");
            }
        }
        public void AumentaAlt(double mai)
        {
            if (Altitude + mai > 8000)
            {
                Console.WriteLine("Você não pode subir tanto, pare no 8000Km de altura.");
            }
            else
            {
                Altitude = Altitude + mai;
                Console.WriteLine("Você subiu para " + Altitude + "Km de altura.");
            }
        }
        public void DiminuiAlt(double meno)
        {
            if (Altitude - meno < 0)
            {
                Console.WriteLine("Você não pode decer tanto, pare no 0Km de altura.");
            }
            else
            {
                Altitude = Altitude - meno;
                Console.WriteLine("Você deceu para " + Altitude + "Km de altura.");
            }
        }

    }
}