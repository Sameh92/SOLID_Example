using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.After
{
    internal static class QuestionBank
    {
        public static List<Question>Generate()
        {
            return new List<Question>
            {
                new WHQuestion
                {
                    Title ="What are the four pillars of OOP?",
                    Mark=8
                },
                new MultipleChoiceQuestion
                {
                    Title="Which of the following are value types",                
                    Mark=6,
                    Choices=new List<string>
                    {
                        "A:Interger",
                        "B:Array",
                        "C:Single",
                        "D:String",
                        "E:Long"
                    }
                },
                new TrueFalseQuestion
                {
                    Title="Earth is Bigger than Sun?",                  
                    Mark=4,

                },
                new MultipleChoiceQuestion
                {
                    Title="Which of the folowing is an 8-byte Integer?",                
                    Mark=3,
                    Choices=new List<string>
                    {
                        "A:Chart",
                        "B:Long",
                        "C:Short",
                        "D:Byte",
                        "E:Intger"
                    }
                },
                new MatchQuestion
                {
                    Title="Match Column 1 value with single choice from 2nd column",
                    Mark=7,
                    Rows=new Dictionary<string, string>{
                        {"A","b" },
                        {"B","c" },
                        {"C","a" },
                        {"D","e" },
                        {"E","d" }
                    }
                }
            };
        }
    }
}
