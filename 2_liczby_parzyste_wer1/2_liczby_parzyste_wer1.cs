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

        Console.Write("Liczby: ");
        while (licz < n)
        {
            int numer = random.Next(-8, 9);
            ileLos++;

            if (numer % 2 == 0)
            {
                Console.Write(numer);

                licz++;

                if (licz < n)
                {
                    Console.Write(", ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Liczba faktycznych losowań: " + ileLos);

        Console.ReadLine();
    }
}
