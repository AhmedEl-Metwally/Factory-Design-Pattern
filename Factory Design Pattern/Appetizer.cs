using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
   

    public interface IAppetizer : IDish
    {
    }

    public class ChickenSalad : Dish, IAppetizer
    {
        public ChickenSalad(string Size, string Calories, decimal Price, List<string> ingredients)
             : base(Size, Calories, Price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Chicken Salad \n▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class ButterCracker : Dish, IAppetizer
    {
        public ButterCracker(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients) { }


        public void serve()
        {
            Console.WriteLine($"Butter Cracker \n▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class CheeseTwist : Dish, IAppetizer
    {
        public CheeseTwist(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Cheese Twist \n▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class PotatoBite : Dish, IAppetizer
    {
        public PotatoBite(string size, string calories, decimal price, List<string> ingredients)
            : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Potato Bite \n▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
