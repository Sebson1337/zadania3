using System;

class Program
{
    static void Main()
    {
        //NA POCZATKU ZROBILEM TAK, ABY PODAC 5 LICZB KTORE UTWORZA TABLICE, POTEM PROGRAM BEDZIE SZUKAL NAJWIEKSZEJ I NAJMNIEJSZEJ
        int[] tablica = new int[5];

        Console.WriteLine("Podaj 5 liczb: ");

        
        for (int i = 0; i < 5; i++)
        {
          tablica[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int najmniejsza = tablica[0];
        int najwieksza = tablica[0];

        
        for (int i = 1; i < 5; i++)
        {
            if (tablica[i] < najmniejsza)
            {
                najmniejsza = tablica[i];
            }

            if (tablica[i] > najwieksza)
            {
                najwieksza = tablica[i];
            }
        }
         Console.WriteLine("Najmniejsza liczba: "+ najmniejsza);
        Console.WriteLine("Największa liczba: "+ najwieksza);
        Console.ReadLine();
    }
}