using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Game
    {
        public Game()
        {

        }

        public List<Question> Questions { get; set; }

        public void CreateQuestions()
        {
            Questions = new List<Question>();   
            var q = new Question()
            {
                Id = 1,
                Category= 100,
                Content = "Jak miał na imię Eintein?",
                Answers= new List<Answer>()
            };

            var a1 = new Answer();
            a1.Id = 1;
            a1.Content = "Albert";
            a1.IsCorrect= true;
            q.Answers.Add(a1);
            
            var a2 = new Answer();
            a2.Id = 2;
            a2.Content = "Aaron";
            a2.IsCorrect = false;
            q.Answers.Add(a2);

            var a3 = new Answer();
            a3.Id = 3;
            a3.Content = "Anthony";
            a3.IsCorrect = false;
            q.Answers.Add(a3);

            var a4 = new Answer();
            a4.Id = 4;
            a4.Content = "Basia";
            a4.IsCorrect = false;
            q.Answers.Add(a4);

            Questions.Add(q);
        }
    }
}
