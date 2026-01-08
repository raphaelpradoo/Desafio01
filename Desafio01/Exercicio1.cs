namespace Desafio01;

public class Exercicio1
{
    /// <summary>
    /// Função que exibe uma mensagem de boas vindas com o nome inserido pelo usuário
    /// </summary>
    /// <param name="nome"></param>
    /// <returns></returns>
    public string exibeMensagem()
    {
        string nome = "";

        do
        {
            // Limpa a tela
            Console.Clear();
            
            // Exibe uma mensagem ao usuário
            Console.WriteLine("Exercicio 1 - Qual seu nome ?");
            
            // Recebe o nome digitato pelo usuário
            nome = Console.ReadLine();

            //Verifica se o nome digitado é nulo ou vazio
        } while (String.IsNullOrWhiteSpace(nome));

        return String.Concat("Olá, ", nome, "! Seja bem vindo!");
    }
}