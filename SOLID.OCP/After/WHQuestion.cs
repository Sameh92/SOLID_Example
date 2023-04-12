using System;

namespace SOLID.OCP.After
{
    public class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine(" -------------------------------");
            Console.WriteLine(" -------------------------------");
            Console.WriteLine(" -------------------------------");
        }
    }
}
