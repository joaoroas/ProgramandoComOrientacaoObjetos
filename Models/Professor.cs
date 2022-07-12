namespace ProgramandoComOrientacaoObjetos.Models
{
    public sealed class Professor : Pessoa
    {
        public int Salario { get; set; }

         public  sealed override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {Nome} e meu salário é: {Salario}");
            Console.ReadLine();
        }
    }
}