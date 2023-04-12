using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.After
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
                question.Print();               
            }
                
            }
        }
    }

