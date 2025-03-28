using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<int> setA = WczytajZbior("A");
        HashSet<int> setB = WczytajZbior("B");

        Console.WriteLine("\nOperacje na zbiorach:");

        // Suma zbiorów
        var suma = new HashSet<int>(setA);
        suma.UnionWith(setB);
        Console.WriteLine("Suma zbiorów: " + string.Join(", ", suma));

        // Różnica zbiorów A - B
        var roznicaAB = new HashSet<int>(setA);
        roznicaAB.ExceptWith(setB);
        Console.WriteLine("Różnica: " + string.Join(", ", roznicaAB));

        // Część wspólna zbiorów
        var wspolne = new HashSet<int>(setA);
        wspolne.IntersectWith(setB);
        Console.WriteLine("Część wspólna: " + string.Join(", ", wspolne));

        // Różnica symetryczna
        var roznicaSym = new HashSet<int>(setA);
        roznicaSym.SymmetricExceptWith(setB);
        Console.WriteLine("Różnica symetryczna: " + string.Join(", ", roznicaSym));
    }

    static HashSet<int> WczytajZbior(string nazwa)
    {
        Console.Write($"Podaj elementy zbioru {nazwa} (oddzielone spacją): ");
        string input = Console.ReadLine();
        return new HashSet<int>(input.Split(' ').Select(int.Parse));
    }
}
