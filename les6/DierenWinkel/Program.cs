using System;

namespace DierenWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
            // hier sla ik de tekst goedemorgen op de string welkomstbericht
            string welkomstBericht = "Goedemorgen!";

            Werknemer ingrid = new Werknemer()
            {
                WelkomstBericht= "Goedemorgen!",
            VoorLetter = 'I',
                Leeftijd = 31,
                Lengte = 175.4,
                Gewicht = 60
            };


            Werknemer anjali = new Werknemer()
            {
                WelkomstBericht = "Goedendag!",
                VoorLetter = 'A',
                Leeftijd = 25,
                Lengte = 164,
                Gewicht = 55
            };

            bool isManagerAanwezig = true;
            bool winkelOpen = true;


            while (winkelOpen) {
                Console.WriteLine(ingrid.WelkomstBericht);
                Console.WriteLine("Kan ik u ergens mee van dienst zijn? (j/n)");

                string antwoord1 = Console.ReadLine();
                if (antwoord1 == "j") {
                    Console.WriteLine("Wat wilt u weten");
                    string antwoord2 = Console.ReadLine();
                    Console.WriteLine("Sorry, ik weet dat niet!");
                    Console.WriteLine("Moet ik de manager halen? (j/n)");
                    string antwoord3 = Console.ReadLine();

                    if (isManagerAanwezig != true)
                    {
                        Console.WriteLine("Sorry, hij is er niet");
                    }
                    Console.Write("Tot");
                    Console.Write(" ");
                    Console.WriteLine("ziens");

                    //De manager komt net voordat de klant wegloopt binnen
                    Console.WriteLine($"Wou de klant mij spreken, {ingrid.VoorLetter}");
                    if (antwoord3 != "n")
                    {
                        Console.WriteLine($"{ingrid.VoorLetter}: {antwoord1} met deze vraag {antwoord2}");
                    }
                }
                else
                {
                    Console.WriteLine("Veel succes met winkelen");
                }
            }
            Console.ReadLine();
        }
    }
}
