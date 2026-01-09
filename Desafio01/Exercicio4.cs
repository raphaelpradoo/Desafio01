namespace Desafio01;

public class Exercicio4
{
    /// <summary>
    /// Função que retorna a quantidade de caracteres do texto digitado pelo usuário
    /// </summary>
    /// <returns></returns>
    public string contaCaracteres()
    {
        int numeroCaracteres = quantidadeCaracteres();

        return $"A quantidade de caracteres da frase é: {numeroCaracteres}";
    }
    /// <summary>
    /// Função que recebe e conta a quantidade de caracteres de uma texto digitado pelo usuário
    /// </summary>
    /// <returns></returns>
    private int quantidadeCaracteres()
    {
        string texto = "";
        do
        {
            // Exibe uma mensagem ao usuário
            Console.WriteLine($"Exercício 4 - Digite sua frase:");

            // Recebe o texto digitato pelo usuário
            texto = Console.ReadLine();

            //Verifica se o texto digitado é nulo ou vazio        
        } while (String.IsNullOrWhiteSpace(texto));

        // Retorna a quantidade de caracteres da frase, não contabilizando os espaços vazios
        return texto.Count(c => !char.IsWhiteSpace(c));
    }
}