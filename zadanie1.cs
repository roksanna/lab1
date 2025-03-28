using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int x = random.Next(1, 16); 
        int proba;
        int liczbaProb = 0;
        
        Console.WriteLine("Zgadnij liczbę z zakresu 1-15!");
        
        do
        {
            Console.Write("Podaj liczbę: ");
            
            while (!int.TryParse(Console.ReadLine(), out proba))
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę całkowitą.");
                Console.Write("Podaj liczbę: ");
            }
            
            liczbaProb++;
            
            if (proba < x)
            {
                Console.WriteLine("Podana liczba jest za mała.");
            }
            else if (proba > x)
            {
                Console.WriteLine("Podana liczba jest za duża.");
            }
            else
            {
                Console.WriteLine($"Gratulacje! Odgadłeś liczbę {x} w {liczbaProb} próbach.");
            }
            
        } while (proba != x);
    }
}
