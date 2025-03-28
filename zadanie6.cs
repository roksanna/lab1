using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> liczbyPierwsze = new HashSet<int>();
        string input;

        Console.WriteLine("Podaj liczby (wpisz 'koniec' aby zakończyć):");

        while (true)
        {
            input = Console.ReadLine();

            if (input.ToLower() == "koniec")
            {
                break;
            }

            if (int.TryParse(input, out int liczba) && CzyLiczbaPierwsza(liczba))
            {
                liczbyPierwsze.Add(liczba); 
            }
        }

        Console.WriteLine("Unikalne liczby pierwsze, które podałeś:");
        foreach (var liczba in liczbyPierwsze)
        {
            Console.WriteLine(liczba);
        }
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
