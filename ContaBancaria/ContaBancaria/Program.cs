namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco ETEC MCM!");

            //Instanciar a classe Conta e criar um objeto
            Conta conta = new Conta();
            conta.Consulta_saldo();

            conta.Depositar(1000);

            conta.Consulta_saldo();

            conta.Sacar(30);

            conta.Consulta_saldo();

            //conta.Sacar(3000);

            conta.Ajuste_limite(1000);
            conta.Consulta_saldo();
            conta.Sacar(1050);
            conta.Consulta_saldo();
        }
    }
}