using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops.Helpers
{
    public class TryCatch
    {
        public TryCatch()
        {
            Console.WriteLine(SetTryCatch("123"));
            Console.WriteLine(SetTryCatch("10v"));
            //Console.WriteLine(TryWithoutCatch("10v"));

        }
        public bool SetTryCatch(string val)
        {
            try
            {
                var x = int.Parse(val);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("input value: " + val);
            }
            return false;
        }

        public bool TryWithoutCatch(string val)
        {
            try
            {
                var x = int.Parse(val);
                return true;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            finally
            {
                Console.WriteLine("input value: " + val);
            }
            return false;
        }
    }
}
