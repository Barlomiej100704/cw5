using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę liczb pierwszych do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        int licz = 0;
        int numer = 2;

        while (licz < n)
        {
            if (LiczbaPierwsza(numer))
            {
                Console.WriteLine(numer);
                licz++;
            }

            numer++;
        }

        Console.ReadLine();
    }

    static bool LiczbaPierwsza(int numer)
    {
        if (numer < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numer); i++)
        {
            if (numer % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
