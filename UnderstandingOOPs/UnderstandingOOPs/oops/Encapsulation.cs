using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    internal class Encapsulation
    {
        private int _count;
        public Encapsulation()
        {
            _count = 0;
        }

        private void _Add()
        {
            _count++;
        }

        public void Add()
        {
            _Add();
        }
        public int count()
        {
            return _count;
        }
    }
}
