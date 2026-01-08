namespace Desafio01;
class Program
{
    static void Main()
    {
        #region Exercicio 01
        
        Exercicio1 exercicio1 = new Exercicio1();
        Console.WriteLine(exercicio1.exibeMensagem());
        Console.WriteLine("****** Fim do Exercicio 1 ****** \n");
        
        #endregion

        #region Exercicio 02        

        Exercicio2 exercicio2 = new Exercicio2();
        Console.WriteLine(exercicio2.nomeCompleto());
        Console.WriteLine("****** Fim do Exercicio 2 ****** \n");

        #endregion
    }
}