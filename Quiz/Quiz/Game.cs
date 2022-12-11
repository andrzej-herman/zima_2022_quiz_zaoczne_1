﻿using Newtonsoft.Json;
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
            // tworzymy bazę pytań
            CreateQuestions();

            // ustawiam bieżaca kategorię na najniższą mozliwą
            CurrentCategory = 100;

            Random = new Random();
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }


        private void CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        // losowanie pytanie
        public void GetQuestion()
        {
            var qCC = Questions.Where(x => x.Category == CurrentCategory).ToList(); 
            var number = Random.Next(0, qCC.Count);
            var question = qCC[number];

            // mieszamy kolejnością odpowiedzi
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            // pętlą for
            //for (int i = 0; i < question.Answers.Count; i++)
            //{
            //    question.Answers[i].ShowOrder = i + 1;
            //}

            // pętlą foreach
            var index = 1;
            foreach (var answer in question.Answers)
            {
                answer.ShowOrder = index;
                index++;
            }

            
            CurrentQuestion = question;
        }


        // walidacja odpowiedzi gracza
        // sprawdzamy czy odpowiedział poprawnie
        public bool CheckPlayerAnswer(int playerNumber)
        {
            var answer = CurrentQuestion.Answers.FirstOrDefault(x => x.ShowOrder == playerNumber);
            return answer.IsCorrect;
        }
    }
}
