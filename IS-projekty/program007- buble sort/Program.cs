
using System.Diagnostics;

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
    Stopwatch myStopwatch = new Stopwatch();

    int myCompare = 0;
    int myChange = 0;


myStopwatch.Start();
for(int i =0; i < n-1; i++) {
    for(int j = 0; j < n - i - 1; j++){
        myCompare++;
        if(myArray[j] < myArray[j+1]) {
            int tmp = myArray[j+1];
            myArray[j+1] = myArray[j];
            myArray[j] = tmp
            myChange++;
        }
    }
}
myStopwatch.Stop();



Console.WriteLine("\n\nSeřazené pole");
for(int i=0; i < n-1; i++) {
    Console.Write("{0};", myArray[i]);
}

Console.ForegroundColor = ConsoleColor.DarkGreen
Console.BackgroundColor = ConsoleColor.Green
Console.WriteLine("Cas potřebný na seřazení pole pomocí algoritmu Bubble sort: {0}", myStopwatch.Elapsed);
Console.WriteLine("\n\nPOčet porovnání: {0}", myCompare);
Console.WriteLine("\n\nPOčet změn: {0}", myChange);




             Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();