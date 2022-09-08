using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    //interface naming - ALWAYS STARTS WITH AN "I"
    interface IWalkAway
    {
        //everything is naturally public in interfaces
        //every class that inherits from IWalkAway must take in this method WalkAway()
        //can be implemented in child class
        void WalkAway(Player player);
    }
}
