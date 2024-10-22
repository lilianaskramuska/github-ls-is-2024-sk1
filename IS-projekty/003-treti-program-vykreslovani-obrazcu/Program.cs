using System;

class Program {
    static void Main() {
        string again = "a";
        while (again == "a") {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("**** Výpis řady čísel ****");
            Console.WriteLine("***********************");
            Console.WriteLine("*** Liliana Skramuska ***");
            Console.WriteLine("***********************");

            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
            }

            Console.Write("Zadejte čířku obrazce (celé číslo): ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte šířku znovu: ");    
            }

          ///  for(int i=1; i<=10 ;i++) {
            ///    Console.WriteLine(i)
            ///}       

       /// int j=1;
        ///while(j <=10) {
           /// Console.WriteLine(j);
           /// j++;
        ///}

        for(i=1; i<=height; i+++) {
            for(j=1; j<=width; j++) {
            Console.Write("* ")
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
            }
            Console.WriteLine();
        }





        Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'");
            again = Console.ReadLine();
