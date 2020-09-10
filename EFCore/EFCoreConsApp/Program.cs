using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreConsApp.Dto;
using EFDataLayer;
using EFDataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Add a new question...");
            //using (var db = new EFContext())
            //{
            //    db.Questions.Add(
            //        new Question
            //        {
            //            QuestionId = 3,
            //            QuestionText = "Ako je prvi januar srijeda, koji dan ce biti Bozic u januaru iste te godine?",
            //            MultiAnswer = false,
            //            SoftDeleted = false,
            //            Explanation = new Explanation { ExplanationId = 3, ExplanationText = "Bozic je 7 mi dan u mjesecu. Sledeca srijeda je 8 mi dan u mjesecu" },
            //            Answers = new List<Answer>()
            //            {
            //                new Answer{AnswerId=7,Order=1,AnswerText="Utorak",IsCorrect=true},
            //                new Answer{AnswerId =8,Order=2,AnswerText="Srijeda", IsCorrect=false},
            //                new Answer{AnswerId=9,Order=3,AnswerText="Ponedeljak",IsCorrect=false}
            //            }
            //        });

            //    try
            //    {
            //        db.SaveChanges();
            //        Console.WriteLine("Data saved ...");
            //        System.Threading.Thread.Sleep(1000);
            //    }
            //    catch (Exception exc)
            //    {
            //        Console.WriteLine($"Exception Message: {exc.Message}");
            //        Console.WriteLine($"Inner Exception Message: {exc.InnerException.Message}");
            //    }

            //}

            Console.WriteLine("Update question ... add explanation to question");
            using(var db = new EFContext())
            {
                var questionToUpdate = db.Questions
                    .Include(a => a.Answers)
                    .Include(e => e.Explanation)
                    .Where(q => q.QuestionId == 2)
                    .First();

                questionToUpdate.Explanation.ExplanationText = "Na presjeku gornja tri i donja dva kruga su cetiri elipticne povrsine.";

                try
                {
                    db.Questions.Update(questionToUpdate);
                    db.SaveChanges();
                    Console.WriteLine("Data updated and saved");
                }
                catch(Exception exc)
                {
                    Console.WriteLine($"Exception Message: {exc.Message}");
                    Console.WriteLine($"Inner Exception Message: {exc.InnerException.Message}");
                }
            }

            Console.WriteLine("Update question ... change answer in answers");
            using(var db = new EFContext())
            {
                var questionToChangeAnswer = db.Questions
                    .Include(a => a.Answers)
                    .Include(e => e.Explanation)
                    .Where(q => q.QuestionId == 1)
                    .First();

                var newAnswers = new List<Answer>()
                {
                    new Answer{AnswerId=1,AnswerText="120",IsCorrect=true,Order=1},
                    new Answer{AnswerId=2,AnswerText="130",IsCorrect=false,Order=2},
                    new Answer{AnswerId=3,AnswerText="140",IsCorrect=false,Order=3}
                };

                questionToChangeAnswer.Answers = newAnswers;

                try
                {
                    db.Questions.Update(questionToChangeAnswer);
                    db.SaveChanges();
                    Console.WriteLine("Data updated and saved ...");
                }
                catch(Exception exc)
                {
                    Console.WriteLine($"Exception Message: {exc.Message}");
                    Console.WriteLine($"Inner Exception Message: {exc.InnerException.Message}");
                }
            }

            Console.WriteLine("Hide question with SoftDelete method instead of removing ...");

            using(var db = new EFContext())
            {
                var questionToHide = db.Questions
                    .Include(a => a.Answers)
                    .Include(e => e.Explanation)
                    .Where(q => q.QuestionId == 2)
                    .First();

                questionToHide.SoftDeleted = true;

                try
                {
                    db.Update(questionToHide);
                    db.SaveChanges();
                    Console.WriteLine("Data updated to be hidden and saved ...");
                }
                catch(Exception exc)
                {
                    Console.WriteLine($"Exception Message: {exc.Message}");
                    Console.WriteLine($"Inner Exception Message: {exc.InnerException.Message}");
                }
            }


            Console.WriteLine("Display data ...");
            System.Threading.Thread.Sleep(1000);
            using(var db = new EFContext())
            {

                var questions = db.Questions
                    .Include(a => a.Answers)
                    .Include(e => e.Explanation)
                    .Select(p => new QuestionPreview
                    {
                        QuestionText = p.QuestionText,
                        QuestionAnswers = p.Answers,
                        QuestionExplanation = p.Explanation.ExplanationText
                    }).ToList();

                var count = questions.Count();

                foreach(var question in questions)
                {
                    Console.WriteLine($"Question: {question.QuestionText}");
                    Console.WriteLine("=======================================");
                    foreach (var answer in question.QuestionAnswers)
                    {
                        var isAnswerCorrect = (answer.IsCorrect == true) ? "YES" : "NO";
                        Console.WriteLine($"Answer: {answer.AnswerText} Correct: {isAnswerCorrect}");
                    }
                    Console.WriteLine("=======================================");
                    Console.WriteLine($"Explanation: {question.QuestionExplanation}");
                }
            }

            Console.WriteLine("Press any key to quit ...");
            Console.ReadKey();
        }
    }
}
