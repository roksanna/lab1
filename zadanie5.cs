using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());

        if (CzyLiczbaPierwsza(liczba))
        {
            Console.WriteLine($"{liczba} jest liczbą pierwszą.");
        }
        else
        {
            Console.WriteLine($"{liczba} nie jest liczbą pierwszą.");
        }
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba <= 1) 
            return false;
        for (int i = 2; i <= Math.Sqrt(liczba); i++) 
        {
            if (liczba % i == 0)
                return false; 
        }
        return true; 
    }
}
