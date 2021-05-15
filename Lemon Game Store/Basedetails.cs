
namespace Lemon_Game_Store
{

    abstract class BaseDetails // (Abstraction) -  This a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    {
        /*For game details and console details, no need to create these get and set for every class on these properties */
        public string Title { get; set; }
        public string Condition { get; set; }
        public double Price { get; set; }
        public virtual void CreateList() { } // Polymorphism 

    }
}
