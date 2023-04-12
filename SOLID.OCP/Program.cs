using System;

namespace SOLID.OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Like Camerea and  resolution of Camera we just change the glasses of Camera to get different resolution
            //Like lorry also
            //Like bulding aslo
            var quiz = new Before.Quiz(Before.QuestionBank.Generate());
            quiz.Print();
            //var quiz = new After.Quiz(After.QuestionBank.Generate());
            //quiz.Print();
            Console.ReadKey();
        }
    }
}
