using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut13.Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod04();
            Console.ReadKey();
        }

        static void RunMethod01()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);

            var quiz3 = quiz1.Concat(quiz2);
            quiz3.ToQuiz();
        }

        static void RunMethod02()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);

            var questionTitles = quiz1.Select(q => q.Title)
                .Concat(quiz2.Select(q => q.Title));


            foreach (var title in questionTitles)
                Console.WriteLine(title);
           
        }

        static void RunMethod03()
        { 
            var questionTitles =
                        QuestionBank.Randomize(3).Select(q => q.Title)
                        .Concat(QuestionBank.Randomize(2).Select(q => q.Title))
                        .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(11, 14)).Select(q => q.Title));

            foreach (var title in questionTitles)
                Console.WriteLine(title);

        }


        static void RunMethod04()
        {
            var quiz1 = QuestionBank.Randomize(3);
            var quiz2 = QuestionBank.Randomize(2);

            var quiz3 = new [] {  quiz1 , quiz2 }.SelectMany(q => q);

            quiz3.ToQuiz(); 
        }




    }
}
