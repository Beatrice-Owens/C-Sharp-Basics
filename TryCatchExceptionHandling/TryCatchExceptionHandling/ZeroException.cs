using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionHandling
{
    //creating specific exception to handle entries with value 0
    public class ZeroException : Exception
    {
        //2 constructors
        public ZeroException()
            : base() { }
        public ZeroException(string message)
            : base(message) { }
    }
}
