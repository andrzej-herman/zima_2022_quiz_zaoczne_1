using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        private void ShowQuestion()
        {
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
            {
                Console.WriteLine($"{a.ShowOrder}. {a.Content}");
            }
            Console.WriteLine();
            Console.Write("Prosze wybrać numer poprawnej odpowiedzi 1, 2, 3 lub 4 => ");
        }

        public int Display()
        {
            Console.Clear();
            ShowQuestion();
            var playerAnswer = Console.ReadLine();
            bool correctKey = IsCorrectKey(playerAnswer);
            while(!correctKey)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Wcisnałeś nieprawidłowy klawisz");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                ShowQuestion();
                playerAnswer = Console.ReadLine();
                correctKey = IsCorrectKey(playerAnswer);
            }

            return int.Parse(playerAnswer);
        }

        private bool IsCorrectKey(string key)
        {
            bool correctKey = int.TryParse(key, out int number);
            if (!correctKey)
            {
                return false;
            }
            else
            {
                if (number > 0 && number < 5)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
