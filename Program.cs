using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("--- Decomposição Decimal ---\n");

        Console.Write("Digite um número inteiro...: ");
        int numero = int.Parse(Console.ReadLine());

        int unidades = numero % 10;
        int dezenas = (numero / 10) % 10;
        int centenas = (numero / 100) % 10;

        Console.WriteLine("\nO número " + numero + " possui:");
        Console.WriteLine("         " + unidades + " unidade(s)");
        Console.WriteLine("         " + dezenas + " dezena(s)");
        Console.WriteLine("        " + centenas + " centena(s).");
    }
}
