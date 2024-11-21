using System;

class Program
{
    static void Main()
    {
        // Načtení textu od uživatele
        Console.WriteLine("Zadejte text:");
        string text = Console.ReadLine();

        // Počítadla pro jednotlivé kategorie
        int samohlasky = 0, souhlasky = 0, cislice = 0, jineZnaky = 0, velkaPismena = 0;

        // Projít každý znak v textu
        foreach (char c in text)
        {
            // Zkontrolujeme, jestli je znak písmeno
            if (Char.IsLetter(c))
            {
                // Zkontrolovat samohlásky (zohledněno malé i velké písmeno)
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    samohlasky++;
                }
                else
                {
                    souhlasky++;
                }

                // Zkontrolovat, zda je písmeno velké
                if (Char.IsUpper(c))
                {
                    velkaPismena++;
                }
            }
            // Zkontrolujeme, zda je číslice
            else if (Char.IsDigit(c))
            {
                cislice++;
            }
            // Ostatní znaky (mezery, interpunkce, atd.)
            else
            {
                jineZnaky++;
            }
        }

        // Výpis výsledků
        Console.WriteLine($"\nPočet samohlásek: {samohlasky}");
        Console.WriteLine($"Počet souhlásek: {souhlasky}");
        Console.WriteLine($"Počet číslic: {cislice}");
        Console.WriteLine($"Počet jiných znaků: {jineZnaky}");
        Console.WriteLine($"Počet velkých písmen: {velkaPismena}");
    }
}
