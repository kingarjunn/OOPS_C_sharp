using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    internal class AbstractionExample : Abstraction
    {
        public override void Print()
        {
            Console.WriteLine("derived class abstraction");
        }

        public override void PrintWarning()
        {
            Console.WriteLine("override");
        }

        public void Printoriginalwarn()
        {
            base.PrintWarning();
        }

        public static int y = 0;
    }
}
