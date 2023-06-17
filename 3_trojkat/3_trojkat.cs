using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = int.Parse(Console.ReadLine());

        for (int i = 1; i <= wysokosc; i++)
        {
            int numSpacji = wysokosc - i;
            int numPlus = 2 * i - 1;

            Console.Write(new string(' ', numSpacji));
            Console.WriteLine(new string('+', numPlus));
        }

        Console.ReadLine();
    }
}
