using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class FloatPrinter
    {
        private float _data;
        public FloatPrinter(float data)
        {
            _data = data;
        }
        public float PrintData()
        {
            return _data;
        }
    }
}
