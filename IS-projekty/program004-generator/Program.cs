string again = "a";

        while (again == "a") {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("********* Liliana Skramuska *************");
            Console.WriteLine("*****************************************");

Console.WriteLine("Zadejte počet generovaných čísel (celé číslo): ");
int n;
while(!int.TryParse(Console.ReadLine(),out n))

Console.WriteLine("Zadejte dolní mez (celé číslo): ");
int dm;
while(!int.TryParse(Console.ReadLine(),out dm))

Console.WriteLine("Zadejte horní mez (celé číslo): ");
int hm;
while(!int.TryParse(Console.ReadLine(),out hm));

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("zadané hodnoty: ");
Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}, n, dm, hm ");
Console.WriteLine("=================================")
Console.WriteLine();


// hranata zavorka jednorozmerne pole - deklarace pole
int[] myArray = new int[n];

Random randomNumber = new Random();

// odrádkování
Console.WriteLine("/n/nNáhodná čísla: ");
for(int i=0; i<n; i ++ );{
    myArray[i] = randomNumber.Next(dm, hm+1);
    Console.Write("{0}; ", myArray[i]);
}




             Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();
