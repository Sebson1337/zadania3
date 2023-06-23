using System;

class Program
{
    static void Main()
        //W TYM PROGRAMIE TEZ STWORZYLEM TABLICE PODAJAC 5 CYFR
    {
        int[] tablica = new int[5];

        Console.WriteLine("Podaj 5 liczb:");

       
        for (int i = 0; i < 5; i++)
        {
            tablica[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i = 0; i < 5 - 1; i++)
        {
            for (int j = 0; j < 5 - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
        }

        
        Console.WriteLine("Posortowana tablica: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.ReadLine();
    }
}