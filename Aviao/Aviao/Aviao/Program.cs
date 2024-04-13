namespace Aviao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olhe nosso avião MCM...");
            Console.WriteLine("Ele só sobe até 8000Km e só acelera até 950Km/h.");

            Class aviao = new Class();

            aviao.AumentaAlt(7000);
            aviao.DiminuiAlt(5000);
            aviao.AumentaVel(500);
            aviao.DiminuiVel(100);
        }
    }
}