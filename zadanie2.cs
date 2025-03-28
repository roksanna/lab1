using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> liczby = new HashSet<int>();
        string input;

        Console.WriteLine("Podaj liczby (wpisz 'stop' aby zakończyć):");
        
        while ((input = Console.ReadLine()) != "stop")
        {
            if (int.TryParse(input, out int liczba))
                liczby.Add(liczba);
        }
        
        Console.WriteLine($"Unikatowych liczb: {liczby.Count}");
    }
}
