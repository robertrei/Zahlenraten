using System;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine schwierigkeitsstufe ein! 1 (einfach 1-100); 2 (mittel 1- 500); 3 (schwer)"); 

            Zahlenraten(GetDifficulty());
        }
        public static int GetDifficulty()
        {
            int.TryParse(Console.ReadLine(), out int dif);

                switch (dif)
                {
                    case 1:
                    Console.WriteLine("Du hast die Schwierigkeitsstufe einfach gewählt. Gib eine Zahl zwischen 0 und 100 ein!");
                        return 100;// Zahlenbereich 1-100                
                    case 2:
                    Console.WriteLine("Du hast die Schwierigkeitsstufe mittel gewählt. Gib eine Zahl zwischen 0 und 500 ein!");
                    return 500;// Zahlenbereich 1-500                
                    case 3:
                    Console.WriteLine("Du hast die Schwierigkeitsstufe schwer gewählt. Gib eine Zahl zwischen 0 und 1000 ein!");
                    return 1000;// Zahlenbereich 1-1000                 
             
                    default:
                        Console.WriteLine("Du hast einen Falschen Wert eingegeben. Ich neheme die Schwierigkeitsstufe einfach! Gib eine Zahl zwischen 0 und 100 ein!");
                        return 100; // Zahlenberich 1-100
                }
        }

        private static void Zahlenraten(int bereich)
        {
            int a = new Random().Next(bereich);
            var guess = -1;
            int x = 0;
            while (a != guess)
            {
                guess = Convert.ToInt16(Console.ReadLine());
                x++;
                if (guess == a)
                {


                    Console.WriteLine("Du hast gewonnen!");
                    Console.WriteLine($"Du hast {x} versuche gebraucht, um die Zahl {a} zu erraten!");
                }
                else if (guess < a)

                {
                    Console.WriteLine("Deine Zahl ist zu klein!");
                }
                else if (guess > a)

                    Console.WriteLine("Deine Zahl ist zu groß!");
            }

        }
    }
}
