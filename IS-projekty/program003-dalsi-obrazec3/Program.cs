using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*******************");
        Console.WriteLine("******Písmeno N******");
        Console.WriteLine("*******************");
        Console.WriteLine("**Lili SKramuská**");
        Console.WriteLine();

        Console.Write("Zadej výšku N: ");
        int vyska = int.Parse(Console.ReadLine());

        Console.Write("Zadej šířku N: ");
        int sirka = int.Parse(Console.ReadLine());

        for (int i = 0; i < vyska; i++)
        {
            // Levý okraj "N"
            Console.Write("*");

            // Mezery nebo diagonální hvězdička
            for (int j = 0; j < sirka - 2; j++)
            {
                if (j == i)
                    Console.Write("*"); // Diagonála
                else
                    Console.Write(" ");
            }

            // Pravý okraj "N"
            Console.WriteLine("*");
        }
    }
}
