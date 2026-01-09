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
        
        #region Exercicio 03       

        Exercicio3 exercicio3 = new Exercicio3();
        exercicio3.realizaCalculos();
        Console.WriteLine("****** Fim do Exercicio 3 ****** \n");

        #endregion
        
        #region Exercicio 04       

        Exercicio4 exercicio4 = new Exercicio4();
        Console.WriteLine(exercicio4.contaCaracteres());
        Console.WriteLine("****** Fim do Exercicio 4 ****** \n");

        #endregion
        
        #region Exercicio 05       

        Exercicio5 exercicio5 = new Exercicio5();
        Console.WriteLine(exercicio5.placaDoVeiculo());
        Console.WriteLine("****** Fim do Exercicio 5 ****** \n");

        #endregion
        
        #region Exercicio 06       

        Exercicio6 exercicio6 = new Exercicio6();
        exercicio6.exibeDatas();
        Console.WriteLine("****** Fim do Exercicio 6 ****** \n");

        #endregion
    }
}