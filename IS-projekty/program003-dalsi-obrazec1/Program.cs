using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*******************");
        Console.WriteLine("******Diamant******");
        Console.WriteLine("*******************");
        Console.WriteLine("**Lili SKramuská**");

        Console.Write("Zadej výšku diamantu (liché číslo): ");
        int vyska = int.Parse(Console.ReadLine());

        if (vyska % 2 == 0)
        {
            Console.WriteLine("Zadej prosím liché číslo pro správný tvar diamantu.");
            return;
        }

        int stred = vyska / 2;

        // Horní polovina
        for (int i = 0; i <= stred; i++)
        {
            Console.Write(new string(' ', stred - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }

        // Dolní polovina
        for (int i = stred - 1; i >= 0; i--)
        {
            Console.Write(new string(' ', stred - i));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
    }
}
