using System;
using System.Collections.Generic;

public class Programa9
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 9: Detector ingênuo de loop ---");

        Console.Write("Digite um número inicial: ");
        int.TryParse(Console.ReadLine(), out int valor);

        Console.Write("Limite de passos: ");
        int.TryParse(Console.ReadLine(), out int limite);
        if (limite <= 0) limite = 100;

        HashSet<int> visitados = new();
        bool loopDetectado = false;

        for (int passo = 1; passo <= limite; passo++)
        {
            if (visitados.Contains(valor))
            {
                Console.WriteLine($"\nLoop detectado! Valor repetido: {valor}");
                loopDetectado = true;
                break;
            }

            visitados.Add(valor);
            valor = (valor * 2 + 3) % 10; // processo arbitrário discreto
            Console.WriteLine($"Passo {passo}: valor = {valor}");
        }

        if (!loopDetectado)
            Console.WriteLine($"\nNenhum loop detectado em {limite} passos.");

        Console.WriteLine("\nReflexão:");
        Console.WriteLine("→ Detectores ingênuos podem sinalizar loops falsos (falsos positivos)");
        Console.WriteLine("→ Ou não detectar loops reais se o limite for pequeno (falsos negativos)");
    }
}
