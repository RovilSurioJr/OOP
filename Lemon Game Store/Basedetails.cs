using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon_Game_Store
{

    abstract class Basedetails // (Abstraction) -  This a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    {
        // For game details and console details
        // No need to create these get and set for every class
        public string title { get; set; }
        public string condition { get; set; }
        public double price { get; set; }
        public virtual void createlist() { }

    }
}
