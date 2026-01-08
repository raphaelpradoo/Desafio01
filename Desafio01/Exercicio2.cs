namespace Desafio01;

public class Exercicio2
{
    /// <summary>
    /// Função que concatena o nome e o sobrenome inseridos pelo usuário
    /// </summary>
    /// <returns></returns>
    public string nomeCompleto()
    {
        string nome = verificaNuloOuVazio("nome");
        string sobrenome = verificaNuloOuVazio("sobrenome");

        return $"{nome} {sobrenome}";
    }

    /// <summary>
    /// Função que verifica se o texto digitado pelo usuário é nulo ou vazio
    /// </summary>
    /// <param name="parametro">Variável para saber se é NOME ou SOBRENOME</param>
    /// <returns></returns>
    private string verificaNuloOuVazio(string parametro)
    {
        string texto = "";
        do
        {
            // Exibe uma mensagem ao usuário
            Console.WriteLine($"Exercício 2 - Digite seu {parametro}:");

            // Recebe o texto digitato pelo usuário
            texto = Console.ReadLine();

            //Verifica se o texto digitado é nulo ou vazio        
        } while (String.IsNullOrWhiteSpace(texto));

        return texto;
    }
}