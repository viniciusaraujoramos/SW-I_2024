namespace Exerc_video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classe p = new Classe(0123, "Celular", 0, 2300);
            p.imprimir();
            p.entrada(150);
            p.imprimir();
            p.venda(50);
            p.imprimir();
        }
    }
}