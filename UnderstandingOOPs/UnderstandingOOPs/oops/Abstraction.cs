using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    internal abstract class Abstraction
    {
        public abstract void Print();
        public void PrintError()
        {
            Console.WriteLine("error");
        }

        public virtual void PrintWarning()
        {
            Console.WriteLine("warning");
        }

        public static int x = 0;
    }
}
