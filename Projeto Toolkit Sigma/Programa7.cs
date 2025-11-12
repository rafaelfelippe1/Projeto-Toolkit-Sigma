using System;

public class Programa7
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 7: Decisores sobre Σ={a,b} ---");
        Console.WriteLine("1) L_fim_b = { w | w termina com 'b' }");
        Console.WriteLine("2) L_mult3_b = { w | número de 'b's é múltiplo de 3 }");

        int opcao = LerOpcao(1, 2);

        Console.Write("\nDigite a cadeia: ");
        string cadeia = Console.ReadLine() ?? "";

        // Validação: só a/b
        foreach (char c in cadeia)
        {
            if (c != 'a' && c != 'b')
            {
                Console.WriteLine("Símbolo inválido. Só são permitidos 'a' e 'b'.");
                return;
            }
        }

        bool aceita = opcao switch
        {
            1 => cadeia.EndsWith("b"),
            2 => cadeia.Split('b').Length - 1 % 3 == 0,
            _ => false
        };

        Console.WriteLine(aceita ? "SIM — aceita" : "NÃO — rejeita");
    }

    private int LerOpcao(int min, int max)
    {
        while (true)
        {
            Console.Write("Opção: ");
            if (int.TryParse(Console.ReadLine(), out int v) && v >= min && v <= max)
                return v;
            Console.WriteLine("Opção inválida.");
        }
    }
}
