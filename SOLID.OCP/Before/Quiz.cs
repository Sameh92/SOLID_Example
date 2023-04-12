using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Before
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public Quiz(List<Question> questions)
        {
            Questions=questions;
        }
        public void Print()
        {
            foreach (Question question in Questions)
            {
                Console.WriteLine($"{question.Title} [{question.Mark}]");
                switch(question.QuestionType)
                {
                    case QuestionType.WH:
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine(" -------------------------------");
                        Console.WriteLine(" -------------------------------");
                        break;
                    case QuestionType.TRUEFALSE:
                        Console.WriteLine(" 1. T");
                        Console.WriteLine(" 2. F");
                        break;
                    case QuestionType.MULTIPLECHOICE:
                        foreach(var choice in question.Choices)
                        {
                            Console.WriteLine($" {choice}");
                        }
                        break;
                    // fourth modification in case we need to add new Question Type
                    case QuestionType.Match:
                        foreach (var item in question.Rows)
                        {
                            Console.WriteLine($"{item.Key}       {item.Value}");
                        }
                        break;
                    default:break;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
