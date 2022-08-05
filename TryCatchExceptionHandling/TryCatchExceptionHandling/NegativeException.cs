using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionHandling
{
    //creating specific exception to handle negative value input
    public class NegativeException : Exception
    {
        //2 constructors
        public NegativeException()
            : base() { }
        public NegativeException(string message)
            : base(message) { }
    }
}
