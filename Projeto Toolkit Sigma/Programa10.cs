using System;

public class Programa10
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 10: Simulador de AFD ---");
        Console.WriteLine("AFD reconhece L = { w ∈ {a,b}* | número de 'a's é par }");

        Console.Write("Digite a cadeia: ");
        string cadeia = Console.ReadLine() ?? "";

        foreach (char c in cadeia)
        {
            if (c != 'a' && c != 'b')
            {
                Console.WriteLine("Símbolo inválido. Só são permitidos 'a' e 'b'.");
                return;
            }
        }

        string estado = "q0"; // q0 = par, q1 = ímpar

        foreach (char c in cadeia)
        {
            Console.WriteLine($"Estado atual: {estado}, lendo '{c}'");

            if (estado == "q0")
                estado = (c == 'a') ? "q1" : "q0";
            else
                estado = (c == 'a') ? "q0" : "q1";
        }

        bool aceita = estado == "q0";

        Console.WriteLine($"\nEstado final: {estado}");
        Console.WriteLine(aceita ? "ACEITA" : "REJEITA");
    }
}
