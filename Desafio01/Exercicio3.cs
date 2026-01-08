using System.Reflection.Metadata;

namespace Desafio01;

public class Exercicio3
{
    public void realizaCalculos()
    {
        // Recebendo os dados do usuário
        double valor1 = recebeValor();
        double valor2 = recebeValor();

        Console.WriteLine($"Valores válidos digitados: Valor 1 = {valor1}. Valor 2 = {valor2}.");
        Console.WriteLine($"Valor da soma é {somar(valor1, valor2)}");
        Console.WriteLine($"Valor da subtração é {subtrair(valor1, valor2)}");
        Console.WriteLine($"Valor da multiplicação é {multiplicar(valor1, valor2)}");
        Console.WriteLine($"Valor da divisão é {dividir(valor1, valor2)}");
        Console.WriteLine($"Valor da média é {media(valor1, valor2)}");
    }

    /// <summary>
    /// Função que checa e recebe os valores digitados pelo usuário
    /// </summary>
    /// <returns></returns>
    private double recebeValor()
    {
        double valor = 0.0;
        bool entradaValida = false;

        do
        {
            Console.WriteLine("Exercício 3 - Digite um valor numérico diferente de zero:");

            string entrada = Console.ReadLine();

            // Tenta converter para double
            entradaValida = double.TryParse(entrada, out valor);

            if (!entradaValida)
                Console.WriteLine("Entrada inválida. Digite apenas números.");
            else if (valor == 0)
                Console.WriteLine("O valor não pode ser zero.");

            //Verifica se o valor digitado é um caracter ou igual à zero
        } while (!entradaValida || valor == 0);

        return valor;
    }

    private double somar(double x, double y) => x + y;

    private double subtrair(double x, double y) => x - y;

    private double multiplicar(double x, double y) => x * y;

    private double dividir(double x, double y) => x / y;

    private double media(double x, double y) => (x + y)/2;
}