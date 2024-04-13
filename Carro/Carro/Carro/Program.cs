namespace Carro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre no carro...");
            Console.WriteLine("Este carro só vai até 200km/h.");

            Class1 class1 = new Class1();

            class1.AumentaVel(80);
            class1.AumentaVel(150);
            class1.Direita(50);
            class1.Esquerda(50);
            class1.DiminuiVel(50);
        }
    }
}