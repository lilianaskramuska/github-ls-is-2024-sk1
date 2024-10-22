using System;

class Program {
    static void Main() {
        string again = "a";
        while (again == "a") {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("**** Součet cifer ****");
            Console.WriteLine("***********************");
            Console.WriteLine("*** Liliana Skramuska ***");
            Console.WriteLine("***********************");

            Console.Write("Zadejte celé číslo: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

            int suma = 0;
            int multi = 1; // Chybějící inicializace pro násobení cifer
            int numberBackup = number;
            int digit;

            // Pokud je číslo záporné, převrátíme ho na kladné (odstraníme znaménko)
            if (number < 0)
                number = -number;

            // Procházení čísla po cifrách
            while (number >= 10) {
                digit = number % 10;
                number = (number - digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * digit;
            }

            // Poslední cifra
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            multi = multi * number;

            Console.WriteLine();
            Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, multi);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
        }
    }
}

