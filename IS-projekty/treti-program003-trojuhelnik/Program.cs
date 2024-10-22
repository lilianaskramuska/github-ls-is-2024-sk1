using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*******************");
        Console.WriteLine("****Trojúhelnik****");
        Console.WriteLine("*******************");
        Console.WriteLine("**Lili Skramuská**");

        string again;
        do
        {
            Console.Write("Zadej výšku trojúhelníku: ");
            int vyska = int.Parse(Console.ReadLine());

            for (int i = 1; i <= vyska; i++)
            {
                // Vytvoří řádek s hvězdičkami
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
        } while (again.ToLower() == "a");
    }
}

