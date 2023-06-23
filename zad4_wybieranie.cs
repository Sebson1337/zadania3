using System;

class Program
{
    static void Main()
    {

        //POCZATEK WPROWADZANIA TABLICY TAKI SAM JAK W ZADAMIU 2 I 3

        int[] tablica = new int[5];

        Console.WriteLine("Podaj 5 liczb: ");

        
        for (int i = 0; i < 5; i++)
        {
            
            tablica[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i = 1; i < 5; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
        }

        Console.WriteLine("Posortowana tablica:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.ReadLine();
    }
}
