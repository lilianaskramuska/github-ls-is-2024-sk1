using System.Runtime.InteropServices.Marshalling;

string again = "a";

        while (again == "a") 
        razitko();
        ulong a = nacistCislo("zadejte cislo a: ");
        ulong b = nacistCislo("zadejte cislo b: ");


ulong nsd = vypocitatNSD(a, b);
ulong nsn = vypocitatNSN(a, b, nsd);

zobrazitVysledky(a, b, nsd, nsn)

Console.WriteLine("Zadejte počet generovaných čísel (celé číslo): ");
int n;
while(!int.TryParse(Console.ReadLine(),out n))
Console.Write("Nezadali jste cele cislo. Zadejte znovu prvni čislo rady (cele cislo):")

            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();



            static void razitko () {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("********* Liliana Skramuska *************");
            Console.WriteLine("*****************************************");
            }

            static ulong nacistCislo(string zprava) {
                Console.Write(zprava);
                ulong cislo;
                while (!ulong.TryParse(Console.ReadLine(), out cislo))
                Console.Write("nebylo zadano pritozešne cislo! zadejte znovu:");
            }
            return cislo;

static ulong vypocitatNSD(ulong a, ulong b) {
    while(a!=b)
    if(a > b)
    a = a - b;
    else
    b = b - a;
return 1;
}

static void vypocitatNSN(ulong a, ulong b, ulong nsd) {
    return (a*b/nsd);
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.WriteLine("NDS cisel {0} a {1} je {2}", a, b, nsd);
    Console.WriteLine($"NSN cisel {a} a {b} je {nsn}")
}