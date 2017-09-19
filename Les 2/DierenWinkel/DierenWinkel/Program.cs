using System;

namespace DierenWinkel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goedemorgen!");
            // Hier willen we dat de klant alleen j(a) of n(ee) typt
            Console.WriteLine("Kan ik u ergens mee van dienst zijn? (j/n)");
            Console.ReadLine();
            Console.WriteLine("Sorry, ik weet dat niet!");
            Console.WriteLine("Moet ik de manager halen? (j/n)");
            Console.ReadLine();
            Console.WriteLine("Sorry, hij is er niet");
            Console.Write("Tot");
            Console.Write(" ");
            Console.WriteLine("ziens");
            Console.ReadLine();
        }
    }
}
