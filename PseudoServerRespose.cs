using System;
using System.Collections.Generic;
using System.Text;

namespace Exsamen2._0
{
    class PseudoServerRespose<T> where T : class, new()
    {
        public T Data { get; set; }
    }
}
