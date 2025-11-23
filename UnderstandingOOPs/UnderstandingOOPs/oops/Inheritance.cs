using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPs.oops
{
    internal class Inheritance : Encapsulation
    {
        //becaues of Inheritance fromm Encapsulation class from Inheritance class we can access all public methods from Encapsulation class in Inheritance class.
        private string _scount;
        public Inheritance()
        {
            _scount = "0";
        }

        //add new keyword befor void Add() to hide Encapsulation.Add() method
        public void Add()
        {
            _scount = _scount + _scount;
        }

        public void StringAdd()
        {
            _scount = _scount + _scount;
        }

        public string SConcat()
        {
            return _scount;
        }

        public void baseAdd()
        {
            base.Add();
        }
    }
}
