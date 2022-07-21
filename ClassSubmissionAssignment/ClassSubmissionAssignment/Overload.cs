using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    //6. Declare a class to be static
    //created a new file to hold the class since no more than one class should share one file
    public static class Overload
    {
        //5. overload a method: same method name, but operation is adjusted depending on how many args are passed
        //1 arg
        public static int Area(int l)
        {
            int area = l * l;
            return area; //return result of op
        }
        //2 arg
        public static int Area(int l, int w)
        {
            int area = l * w;
            return area;
        }
    }
}
