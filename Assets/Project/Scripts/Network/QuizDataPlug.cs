using System;
using System.Collections.Generic;

public static class FakeQuizData
{
    public static List<QuizQuestion> GetQuestionsById(String quizId)
    {
        if (quizId == "artistsQ")
        {
            return new List<QuizQuestion>()
            {
                new QuizQuestion
                {
                    question = "Who painted Starry Night?",
                    answers = new List<QuizAnswer>
                    {
                        new QuizAnswer { answer = "Van Gogh" },
                        new QuizAnswer { answer = "Monet" },
                        new QuizAnswer { answer = "Da Vinci" },
                        new QuizAnswer { answer = "Picasso" }
                    },
                    correctIndex = 0
                },
                new QuizQuestion
                {
                    question = "Which style is Monet associated with?",
                    answers = new List<QuizAnswer>
                    {
                        new QuizAnswer { answer = "Baroque" },
                        new QuizAnswer { answer = "Impressionism" },
                        new QuizAnswer { answer = "Cubism" }
                    },
                    correctIndex = 1
                },
                new QuizQuestion
                {
                    question = "Where was Leonardo da Vinci born?",
                    answers = new List<QuizAnswer>
                    {
                        new QuizAnswer { answer = "France" },
                        new QuizAnswer { answer = "Italy" },
                        new QuizAnswer { answer = "Spain" },
                        new QuizAnswer { answer = "Germany" }
                    },
                    correctIndex = 1
                }
            };
        }
        else return new List<QuizQuestion>();
    }
}