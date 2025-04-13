using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class AllPurposePrinter<T>
    {
            private T _data;

            public AllPurposePrinter(T data)
            {
                _data = data;
            }

            public T PrintData()
            {
                return _data;
            }

        }
    }
