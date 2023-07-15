﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{

    public interface IMainCourse : IDish
    {
    }

    public class Lasagna : Dish, IMainCourse
    {
        public Lasagna(string size, string calories, decimal price, List<string> ingredients) 
            : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Lasagna \n▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class Steak : Dish, IMainCourse
    {
        public Steak(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Steak \n▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class Molokhiya : Dish, IMainCourse
    {
        public Molokhiya(string size, string calories, decimal price, List<string> ingredients) 
            : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Molokhiya \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class GrilledChicken : Dish, IMainCourse
    {
        public GrilledChicken(string size, string calories, decimal price, List<string> ingredients) 
            : base(size, calories, price, ingredients) { }

        public void serve()
        {
            Console.WriteLine($"Grilled Chicken \n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

}
