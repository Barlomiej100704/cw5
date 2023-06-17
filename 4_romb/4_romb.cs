using System;

class Program
{
    static void Main()
    {
        int proby = 0;
        int rozmiar = 0;

        while (proby < 3)
        {
            Console.Write("Podaj rozmiar rombu (liczba nieparzysta >= 3): ");
            if (!int.TryParse(Console.ReadLine(), out rozmiar))
            {
                Console.WriteLine("Nieprawidłowy format liczby!");
                proby++;
                continue;
            }

            if (rozmiar >= 3 && rozmiar % 2 != 0)
            {
                break;
            }

            Console.WriteLine("Nieprawidłowy rozmiar rombu!");
            proby++;
        }

        if (proby >= 3)
        {
            Console.WriteLine("Nieprawidłowy rozmiar rombu. Koniec programu.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Rysowanie rombu o rozmiarze {0}:", rozmiar);

        char zewSymbol = GetRandomSymbol(new[] { '#', '@', '|', '*' });
        char wewSymbol = GetRandomSymbol(new[] { '.', ':', '-', '+' });

        int polRozmiaru = rozmiar / 2;
        int spacja = polRozmiaru;

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < spacja; j++)
            {
                Console.Write(" ");
            }

            int symbole = rozmiar - 2 * spacja;

            for (int j = 0; j < symbole; j++)
            {
                char symbol;
                if (j == 0 || j == symbole - 1)
                {
                    symbol = zewSymbol;
                }
                else
                {
                    symbol = wewSymbol;
                }

                Console.Write(symbol);
            }

            Console.WriteLine();

            if (i < polRozmiaru)
            {
                spacja--;
            }
            else
            {
                spacja++;
            }
        }

        Console.ReadLine();
    }

    static char GetRandomSymbol(char[] symbole)
    {
        Random random = new Random();
        int index = random.Next(symbole.Length);
        return symbole[index];
    }
}
