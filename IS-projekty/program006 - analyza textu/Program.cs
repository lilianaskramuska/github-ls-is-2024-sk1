using System;

class Program {
    static void Main() {
        string again = "a";
        while (again == "a") {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("**** Analyza textu****");
            Console.WriteLine("***********************");
            Console.WriteLine("***Liliana Skramuska***");
            Console.WriteLine("***********************");

Console.Write("\nZadejte váš text: ");
string myText = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(myText);
Console.WriteLine(myText[0]);
Console.WriteLine(myText.Length);

string samohlasky = "aáeéěiíoóuůúyý";
string souhlasky = "bcčdďfghjklmnvxsdqwrřtťzpzžščř";
string cislice = "0123456789" ;

int pocetSamohlasek = 0;
int pocetSouhlasek = 0;
int pocetCislic = 0;
int pocetOstatnich = 0;

foreach(char znak in myText) {
    if(souhlasky.Contains(znak)) {
        pocetSouhlasek++
    }

      if(samohlasky.Contains(znak)) {
        pocetSamohlasek++
    }

      if(cislice.Contains(znak)) {
        pocetCislic++

          if(souhlasky.Contains(znak)) {
        pocetSouhlasek++
    }
    }
}

 Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'. Pro ukončení stiskněte jinou klávesu.");
            again = Console.ReadLine();