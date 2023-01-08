using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Messages
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("WITAJ W NASZYM QUIZE GR 1");
            Console.WriteLine("Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Wciśnij ENTER aby rozpocząć grę ...");
            Console.ReadLine();
        }


        public void DisplayFailAndGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("NIESTETY, ALE TO NIEPRAWIDŁOWA ODPOWIEDŹ");
            Console.WriteLine("KONIEC GRY !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void FinalScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO, UDAŁO CI SIĘ UKOŃCZYĆ QUIZ !!!");
            Console.WriteLine("KONIEC GRY !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GoodAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Brawo, to prawidłowa odpowiedź ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby wyświetlić następnne pytanie ...");
            Console.WriteLine();
            Console.ReadLine();

        }


    }
}
