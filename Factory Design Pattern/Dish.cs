using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public interface IDish
    {
        void serve();
    }


    public abstract class Dish
    {
        public string Size { get; set; }
        public string Calories { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }


        public Dish(string size, string calories, decimal price, List<string> ingredients) 
        {
            Size = size;
            Calories = calories;
            Price = price;
            Ingredients = ingredients;
        }  
        

        public string ShowDetails()
        {
            // size Medium(100 - 150) call (150)
            // Ingredients Apple, Banana, Orange, Berries

            return $"  ├── Size: {Size} ({Calories}) cal. ({Price.ToString("C")})\n " +
                $" └── Ingredients: {string.Join(", ", Ingredients)}\n";

        }
    }
}
