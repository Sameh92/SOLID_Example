using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Before
{
    public class Question
    {
        public string Title { get; set; }
        public int Mark { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<string> Choices { get; set; }=new List<string>();

        // second modification in case we need to add new Question Type
        public Dictionary<string,string> Rows { get; set; }=new Dictionary<string,string>();

    }
}
