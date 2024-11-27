using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;
string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** PŘEVOD Z 10 DO 2 *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Skramuská Liliana *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.Write("Zadejte číslo v 10 soustavě (přirozené číslo): ");
            uint n;
            while(!uint.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }
           
uint[] myArray = new int[32];
uint zaloha = cislo;
uint zbytek;

for(uint=0, cislo > 0, i++) {
    zbytek = cislo % 2;
    cislo = (cislo - zbytek)/2;
    myArray[i] = zbytek;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Celá část: {0}; zbytek: {1}", cislo, zbytek);
}
Console.WriteLine("Posledni vyuzita bunka pole: {0}", i-1);

Console.WriteLine("\n\nVýsledek:")
for(uint j=int-1)

            }
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();