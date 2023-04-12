using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Before
{
    public enum QuestionType
    {
        WH,
        TRUEFALSE,
        MULTIPLECHOICE,
        // first modification in case we need to add new Question Type
        Match
    }
}
