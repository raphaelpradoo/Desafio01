namespace Desafio01;

public class Exercicio6
{
    public void exibeDatas()
    {
        Console.WriteLine($"Data completa: {dataCompleta()}");
        Console.WriteLine($"Apenas data:  {apenasData()}");
        Console.WriteLine($"Apenas hora: {apenasHora()}");
        Console.WriteLine($"Data com mês por extenso: {dataComMesPorExtenso()}");
    }

    private string dataCompleta() => DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");

    private string apenasData() => DateTime.Now.ToString("dd/MM/yyyy");

    private string apenasHora() => DateTime.Now.ToString("HH:mm:ss");

    private string dataComMesPorExtenso() => DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
}