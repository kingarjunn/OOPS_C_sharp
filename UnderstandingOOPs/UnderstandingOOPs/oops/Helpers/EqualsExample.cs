using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops.Helpers
{
    internal class EqualsExample
    {
        public EqualsExample()
        {
            validate();
        }

        public void validate()
        {
            int x = 1;
            int y = 1;

            string s = "string";
            string s1 = "string2";

            Parent p1 = new Parent() { Id = 1, Name = "Tom" };
            Parent p2 = new Parent() { Id = 1, Name = "Tom" };

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1,"Data");
            dic.Add(2,"Data1");

            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Data");
            dic1.Add(2, "Data1");

            Console.WriteLine($"== for int x,y {x==y} .Equals for int x,y {x.Equals(y)}");
            Console.WriteLine($"== for string s,s1 {s == s1} .Equals for int s,s1 {s.Equals(s1)}");
            Console.WriteLine($"== for object type p1,p2 {p1 == p2} .Equals for int p1,p2 {p1.Equals(p2)}");
            Console.WriteLine($"== for Dictionary {dic == dic1} .Equals for int p1,p2 {dic.Equals(dic1)}");

        }
        

    }

    public class Parent()
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
