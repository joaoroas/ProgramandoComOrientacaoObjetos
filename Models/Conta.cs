namespace ProgramandoComOrientacaoObjetos.Models
{
    public abstract class Conta
    {
        protected double saldo { get; set; }

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {saldo}");
            Console.ReadLine();
        }
    }
}