using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    public class Parent
    { 
        public virtual void overload()
        {
            Console.WriteLine("parent class");
        }

    }

    internal class RunTimePolymorphism : Parent
    {
        public override void overload()
        {
            Console.WriteLine("child class, it should be printing 'parent class' but using inheritance we overridden overload method different code");
        }
        public void original()
        {
            base.overload();
        }
    }
}
