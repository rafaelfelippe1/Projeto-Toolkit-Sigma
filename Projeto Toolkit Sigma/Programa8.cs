using System;

public class Programa8
{
    public void Executar()
    {
        Console.WriteLine("--- Programa 8: Reconhecedor potencialmente não terminante ---");
        Console.WriteLine("L = { a^n b^n | n ≥ 0 } — cadeias com o mesmo número de 'a's e 'b's, nessa ordem.");
        Console.WriteLine("Este reconhecedor pode não terminar em casos fora da linguagem.\n");

        Console.Write("Digite a cadeia: ");
        string cadeia = Console.ReadLine() ?? "";

        Console.Write("Limite de passos (para abortar): ");
        int.TryParse(Console.ReadLine(), out int limite);
        if (limite <= 0) limite = 1000;

        int passos = 0;
        int i = 0;
        bool aceita = true;

        while (i < cadeia.Length && passos < limite)
        {
            passos++;

            if (cadeia[i] == 'a')
            {
                int j = cadeia.IndexOf('b', i);
                if (j == -1) { aceita = false; break; }
                i++;
            }
            else if (cadeia[i] == 'b')
            {
                i++;
            }
            else
            {
                aceita = false;
                break;
            }
        }

        if (passos >= limite)
        {
            Console.WriteLine($"\nExecução interrompida — limite de {limite} passos atingido.");
        }
        else
        {
            Console.WriteLine($"\nResultado: {(aceita ? "ACEITA" : "REJEITA")}");
        }
    }
}
