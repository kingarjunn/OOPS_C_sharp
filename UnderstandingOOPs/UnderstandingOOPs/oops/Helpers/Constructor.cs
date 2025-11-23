using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops.Helpers
{
    internal class Constructor
    {
        private int _a = 0,_b=0;
        public Constructor()
        {
            Console.WriteLine("Default constructor");
        }
        public Constructor(int a , int b)
        {
            _a = a;
            _b = b;
            Console.WriteLine($"Parameter Constructor with parameters {nameof(a)} = {a} & {nameof(b)} = {b}");
        }

        public Constructor(Constructor con)
        {
            _a =con._a;
            _b =con._b;
            Console.WriteLine($"Copy Constructor with parameters {nameof(_a)} = {_a} & {nameof(_b)} = {_b}");

        }
        static Constructor()
        {
            //Console.WriteLine("Static constructor"); will not work
        }
        private Constructor(string a)
        {
            Console.WriteLine("private Constructor invocked");
                
        }

        public static void print()
        {
            Console.WriteLine("Static constructor");
        }

        public static void invoke()
        {
            Constructor con = new Constructor();
            Constructor con2 = new Constructor(1,2);
            Constructor con3 = new Constructor(3,4);
            Constructor.print();
        }
    }
}
