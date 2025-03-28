using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę binarną: ");
        string bin = Console.ReadLine().Trim('0');
        
        int dziury = 0, i = 0;
        while ((i = bin.IndexOf("10", i)) != -1)
        {
            i++;
            dziury++;
        }
        
        Console.WriteLine($"Liczba dziur: {dziury}");
    }
}
