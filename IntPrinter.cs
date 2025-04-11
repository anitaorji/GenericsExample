using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class IntPrinter
    {
        private int _data;
        public IntPrinter(int data)
        {
            _data = data;
        }
        public int PrintData()
        {
            return _data;
        }
    }
}
