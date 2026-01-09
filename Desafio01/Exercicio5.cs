namespace Desafio01;

public class Exercicio5
{
    public string placaDoVeiculo()
    {
        Console.WriteLine("Exercício 5 - Digite a placa do veículo:");
        return $"A placa do veículo é: {(validaPlaca(Console.ReadLine()) ? "Verdadeira" : "Falsa")}";
    }

    /// <summary>
    /// Função que verifica se o formato da placa é verdadeiro ou falso
    /// Verifica se possui exatamente 7 caracteres
    /// Verifica se os 3 primeiros são letras
    /// Verifica se os 4 últimos são números
    /// </summary>
    /// <param name="placa"></param>
    /// <returns></returns>
    private bool validaPlaca(string placa)
    {
        return !string.IsNullOrWhiteSpace(placa)
            && placa.Trim().Length == 7
            && placa.Take(3).All(char.IsLetter)
            && placa.Skip(3).All(char.IsDigit);
    }
}