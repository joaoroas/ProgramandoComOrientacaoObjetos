namespace ProgramandoComOrientacaoObjetos.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

         public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é: {Nome} e minha nota é: {Nota}");
            Console.ReadLine();
        }
    }
}