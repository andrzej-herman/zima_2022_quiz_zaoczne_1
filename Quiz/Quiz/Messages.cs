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
            Console.WriteLine();
            Console.WriteLine("WITAJ W NASZYM QUIZE GR 1");
            Console.WriteLine("Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Wciśnij ENTER aby rozpocząć grę ...");
            Console.ReadLine();
        }
    }
}
