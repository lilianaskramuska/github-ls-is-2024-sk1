using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("********* Liliana Skramuska *************");
            Console.WriteLine("*****************************************");

            // Počet generovaných čísel
            Console.WriteLine("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Chyba! Zadejte celé číslo.");
            }

            // Dolní mez
            Console.WriteLine("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.WriteLine("Chyba! Zadejte celé číslo.");
            }

            // Horní mez
            Console.WriteLine("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm))
            {
                Console.WriteLine("Chyba! Zadejte celé číslo.");
            }

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("=================================");
            Console.WriteLine();

            // Deklarace pole pro náhodná čísla
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            // Generování náhodných čísel
            Console.WriteLine("\n\nNáhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }

int max = myArray[0];
int min = myArray[0];
int poziceMax = 0;
int poziceMin = 0;
//5 10
for(int i = 1; i < n; i++) {
    if(myArray[i] > max) {
        max = myArray[i];
        poziceMax = i;
    
     int(myArray[i] < min) {
     min = myArray[i];
    poziceMin = i;
    }
}

            Console.WriteLine("\n\nMinimum: {0}; jeho prvni pozice v poli: {1}", min, poziceMin);
            Console.WriteLine("Maximum: {0}; jeho prvni pozice v poli: {1}", max,poziceMax);
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
        }
    }
}
