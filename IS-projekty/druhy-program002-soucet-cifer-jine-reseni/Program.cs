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
            string input = Console.ReadLine();

            if (input.StartsWith("-")) {
                Console.WriteLine("Záporná čísla nejsou podporována.");
                continue; // Přeskočí zbytek smyčky a požádá o nové číslo
            }

            int suma = 0;
            int multi = 1; // Inicializace pro násobení cifer
            bool hasDigits = false; // Flag pro kontrolu, jestli bylo zadáno alespoň jedno číslo

            foreach (char c in input) {
                // Pokud je znak číslo, převedeme ho na číselnou hodnotu
                if (char.IsDigit(c)) {
                    hasDigits = true; // Bylo zadáno alespoň jedno číslo
                    int digit = c - '0'; // Převod znaku na číslo
                    suma += digit;
                    if (digit != 0) {
                        multi *= digit; // Násobení pouze pokud je číslo různé od nuly
                    }
                }
            }

            if (!hasDigits) {
                Console.WriteLine("Nezadali jste žádné číslo.");
            } else {
                Console.WriteLine();
                Console.WriteLine("Součet cifer čísla {0} je {1}", input, suma);
                Console.WriteLine("Součin cifer čísla {0} je {1}", input, multi == 1 ? "0 nebo 1 (podle toho, zda bylo zadáno 0)" : multi.ToString());
            }
            
            // Opakování programu 
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
        }
    }
}

