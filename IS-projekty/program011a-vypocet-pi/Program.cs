string again = "a";

        while (again == "a") {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**************Výpočet PI*****************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("********* Liliana Skramuska *************");
            Console.WriteLine("*****************************************");

Console.WriteLine("Zadejte přesnost (reálné číslo): ");
double presnost;
while(!double.TryParse(Console.ReadLine(),out presnost)) {
    Console.WriteLine("Nezadali jste cele cislo, zadejte cele cislo: ")
}
double i = 1;
double znamenko = 1;
double piCtvrt = 1;

while((1/i)>=presnost) {
    i = i + 2;
    znamenko = -znamenko;
    piCtvrt = piCtvrt+znamenko * (1/i);

    if(znamenko==1) {
        Console.WriteLine("Zlomek: +1/{0}; aktualni hodnota PI= {1}", i, 4 * piCtvrt)
    }
    else {
        Console.WriteLine("Zlomek: -1/{0}; aktualni hodnota PI= {1}", i, 4 * piCtvrt)
    }
}


Console.WriteLine("\n\n Hodnota čísla PI = {8}", 4 * piCtvrt)



             Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();