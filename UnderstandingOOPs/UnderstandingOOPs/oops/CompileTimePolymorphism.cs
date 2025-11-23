using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    internal class CompileTimePolymorphism
    {
        //method overloading
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(List<int> list)
        {
            int x = 0;
            foreach (var t in list)
            {
                x = x + t;
            }
            Console.WriteLine(x);
        }
    }
}
