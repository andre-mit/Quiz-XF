using Quiz.Models;
using System.Collections.Generic;

namespace Quiz.Services
{
    public static class QuestionsStore
    {
        public static List<Question> Questions = new List<Question>
        {
            new Question
            {
                QuestionText = ".NET é um framework desenvolvido por:",
                Alternatives= new string[]
                {
                    "Oracle", "Microsoft", "Facebook", "Google"
                },
                Correct = 1
            },
            new Question
            {
                QuestionText = "Qual a linguagem de programação a qual os navegadores conseguem executar?",
                Alternatives= new string[]
                {
                    "HTML", "Typescript", "C#", "JavaScript"
                },
                Correct = 3
            },
            new Question
            {
                QuestionText = "O nome do framework para criar serviços web com C#, é...",
                Alternatives= new string[]
                {
                    "React", "Xamarin", "ASP.NET", "Angular"
                },
                Correct = 2
            },
            new Question
            {
                QuestionText = "O que significa JSON?",
                Alternatives= new string[]
                {
                    "JavaScript Object Notation", "Personagem de sexa-feira 13", "Humorista", "Linguagem de programação"
                },
                Correct = 0
            },
            new Question
            {
                QuestionText = "JavaScript é uma lingugem...",
                Alternatives= new string[]
                {
                    "Orientada a Objetos", "Fortemente tipada", "Multiparadigma", "de baixo nível"
                },
                Correct = 2
            },
        };
    }
}
