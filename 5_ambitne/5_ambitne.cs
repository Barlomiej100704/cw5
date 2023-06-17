using System;

class Program
{
    static void Main()
    {
        int x, n;

        while (true)
        {
            Console.Write("Podaj wartość x: ");
            if (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.WriteLine("Nieprawidłowa wartość x!");
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Write("Podaj wartość n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Nieprawidłowa wartość n!");
                continue;
            }

            break;
        }

        int wynik = 1;

        for (int i = 0; i < n; i++)
        {
            int term = 0;

            for (int j = 0; j < x; j++)
            {
                term += wynik;
            }

            wynik = term;
        }

        Console.WriteLine($"Wynik otrzymany algorytmem: {wynik}");

        double poprawnyWynik = Math.Pow(x, n);

        Console.WriteLine($"Wynik prawidłowy: {poprawnyWynik}");

        if (wynik == poprawnyWynik)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki nie są zgodne.");
        }
        Console.ReadLine();
    }
}
