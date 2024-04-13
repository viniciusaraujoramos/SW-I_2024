using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Class1
    {
        private double Velocidade { get; set; }
        private double Direcao { get; set; }

        public void AumentaVel(double mais)
        {
            if (Velocidade+mais > 200)
            {
                Console.WriteLine("Você não pode acelerar tanto, pare no 200.");
            }
            else
            {
                Velocidade = Velocidade + mais;
                Console.WriteLine("Sua velociade é " + Velocidade+"Km/h");
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
                Console.WriteLine("Sua velociade é " + Velocidade+"Km/h");
            }
        }
        public void Direita(double mai)
        {

            Direcao = mai;
            Console.WriteLine("Você virou "+Direcao+" graus para a direita");
        
        }
        public void Esquerda(double meno)
        {
        
            Direcao = meno;
            Console.WriteLine("Você virou "+Direcao+" graus para esquerda");
        
        }
    }
}
