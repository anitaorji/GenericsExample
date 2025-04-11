using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
        class StringPrinter
        {
            private string _data;
            public StringPrinter(string data)
            {
                _data = data;
            }
            public string PrintData()
            {
                return _data;
            }
        }
}
