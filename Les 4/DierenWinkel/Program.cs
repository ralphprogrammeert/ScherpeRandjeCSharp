using System;

namespace DierenWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
            // hier sla ik de tekst goedemorgen op de string welkomstbericht
            string welkomstBericht = "Goedemorgen!";

            char voorLetterWerknemer = 'I';
            int leeftijdWerknemer = 31;
            double lengteWerknemer = 180.4;
            float gewichtWerknemer = 60;
            bool isManagerAanwezig = true;

            string naamWerkneemster = "Ingrid";
 
            Console.WriteLine(welkomstBericht);
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
                Console.WriteLine($"Wou de klant mij spreken, {naamWerkneemster}");
                if (antwoord3 != "n")
                {
                    Console.WriteLine($"{naamWerkneemster}: {antwoord1} met deze vraag {antwoord2}");
                }
            }
            else
            {
                Console.WriteLine("Veel succes met winkelen");
            }
            Console.ReadLine();
        }
    }
}
