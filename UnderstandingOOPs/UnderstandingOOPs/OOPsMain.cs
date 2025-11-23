using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandingOOPs.oops;

namespace UnderstandingOOPs
{
    internal class OOPsMain
    {
        public static void RunOOPsMain() 
        {
             /*Encapsulation = Hiding data using access modifiers, 
             you cannot access private variables out side the class they cab be access creating public method that can access private method in side the class 
             look inside the Encapsulation class
             */
            Encapsulation en = new Encapsulation();

            /*
             Inheritance = This allows a new class (child class) to inherit properties and behaviors from an existing class
                see inside Inheritance
             */
            Console.WriteLine("Inheritance");
            Inheritance inh = new Inheritance();
            inh.Add();
            Console.WriteLine(inh.count() + " " + inh.SConcat());
            inh.baseAdd();
            Console.WriteLine(inh.count() + " " + inh.SConcat());


            Console.WriteLine("Abstraction");
            //Abstraction = hiding actual code , only showing method name and return type. can be acheive by interface / abstract class

            //--------------------------------------------------------
            Console.WriteLine(Abstraction.x + AbstractionExample.y);
            Abstraction.x = 2;
            AbstractionExample.y = 2;
            //--------------------------------------------------------

            AbstractionExample abe = new AbstractionExample();
            abe.Print();
            abe.PrintWarning();
            abe.Printoriginalwarn();
            Console.WriteLine(Abstraction.x + AbstractionExample.y);
            //------------------------------------------------------------

            //polymorphism
            // same method name but it accept different parameters and have different processes
            Console.WriteLine("CompileTimePolymorphism");

            CompileTimePolymorphism ctp = new CompileTimePolymorphism();
            ctp.Add(1, 2);
            ctp.Add("pro" , "ton"); 
            ctp.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, });
            //------------------------------------------------------------------------------------

            Console.WriteLine("RunTimePolymorphism");
            RunTimePolymorphism rm = new RunTimePolymorphism();
            rm.overload();
            rm.original();
        }
    }
}
