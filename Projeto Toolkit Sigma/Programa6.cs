using System;
using System.Text.Json;

public class Programa6
{
    private record Frase(string Texto, string Tipo);

    public void Executar()
    {
        Console.WriteLine("--- Programa 6: Classificador P/I por JSON ---");

        // JSON embutido (não usar arquivo externo)
        string json = @"[
            { ""Texto"": ""Aquecimento global causa aumento do nível do mar."", ""Tipo"": ""P"" },
            { ""Texto"": ""O derretimento das calotas polares é uma consequência climática."", ""Tipo"": ""I"" },
            { ""Texto"": ""A falta de saneamento básico provoca doenças infecciosas."", ""Tipo"": ""P"" },
            { ""Texto"": ""A leptospirose é causada por contato com urina de ratos."", ""Tipo"": ""I"" }
        ]";

        var frases = JsonSerializer.Deserialize<Frase[]>(json)!;

        int acertos = 0;

        foreach (var f in frases)
        {
            Console.WriteLine($"\nFrase: {f.Texto}");
            Console.Write("Classifique como Problema (P) ou Instância (I): ");
            string? resposta = Console.ReadLine()?.Trim().ToUpper();

            if (resposta == f.Tipo)
            {
                Console.WriteLine("✔️ Correto!");
                acertos++;
            }
            else
            {
                Console.WriteLine($"❌ Errado! Resposta correta: {f.Tipo}");
            }
        }

        Console.WriteLine($"\nResultado final: {acertos}/{frases.Length} acertos.");
    }
}
