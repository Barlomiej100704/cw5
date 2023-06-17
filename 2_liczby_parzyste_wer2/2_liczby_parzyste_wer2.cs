using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę liczb parzystych do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int licz = 0;
        int ileLos = 0;

        Console.Write("Wersja 2: ");
        while (licz < n)
        {
            int numer = random.Next(-4, 5) * 2;
            ileLos++;

            Console.Write(numer);

            licz++;

            if (licz < n)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba faktycznych losowań: " + ileLos);

        Console.ReadLine();
    }
}
