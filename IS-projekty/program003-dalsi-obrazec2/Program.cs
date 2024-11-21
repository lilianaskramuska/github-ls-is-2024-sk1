using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej výšku přesýpacích hodin (liché číslo): ");
        int vyska = int.Parse(Console.ReadLine());

        if (vyska % 2 == 0)
        {
            Console.WriteLine("Zadej prosím liché číslo pro správný tvar přesýpacích hodin.");
            return;
        }

        int stred = vyska / 2;

        // Vrchní polovina
        for (int i = 0; i <= stred; i++)
        {
            Console.Write(new string(' ', i));
            Console.WriteLine(new string('*', vyska - 2 * i));
        }

        // Spodní polovina
        for (int i = stred - 1; i >= 0; i--)
        {
            Console.Write(new string(' ', i));
            Console.WriteLine(new string('*', vyska - 2 * i));
        }
    }
}
