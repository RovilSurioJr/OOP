using System;
using System.Collections.Generic;
using System.Text;

namespace Lemon_Game_Store
{
    
    class Basedetails
    {
        //Basedetails is also an abstraction
        // For game details and console
        //  This is class is for inheritance, so that we will not create these get and set for every class
        public string title { get; set; }
        public string condition { get; set; }
        public double price { get; set; }

    }
}
