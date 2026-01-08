namespace Desafio01;
class Program
{
    static void Main()
    {
        Console.WriteLine("Qual seu nome ?");
        string nome = Console.ReadLine();
        
        Exercicio1 exercicio1 = new Exercicio1();
        Console.WriteLine(exercicio1.exibeMensagem(nome));
        
    }
}