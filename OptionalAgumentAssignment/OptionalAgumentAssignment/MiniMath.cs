using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalAgumentAssignment
{
    public class MiniMath //make class public so Program.cs can access its contents
    {
        //PlusSome method takes necessary arg num1 and optional int arg
        public static int PlusSome(int num1, int optionalNum = 1) 
        {
            int sum = num1 + optionalNum; //basic addition op
            return sum; //return results
        }
    }
}
