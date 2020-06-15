using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            buffet.Menu.Add(new Food("Pizza", 500, false, false));
            buffet.Menu.Add(new Food("Ice Cream", 400, false, true));
            buffet.Menu.Add(new Food("Cheeseburger", 550, false, false));
            buffet.Menu.Add(new Food("Tacos", 400, true, false));

            Ninja tom = new Ninja();
            while(tom.IsFull != true)
            {
                tom.Eat(buffet.Serve());
            }
            tom.Eat(buffet.Serve());
        }
    }

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy = isSpicy;
            this.IsSweet = isSweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            this.Menu = new List<Food>();
        }

        public Food Serve()
        {
            Random rand = new Random();
            return this.Menu[rand.Next(this.Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public bool IsFull
        {
            get { return this.calorieIntake > 1200; }
        }

        public Ninja()
        {
            this.FoodHistory = new List<Food>();
            this.calorieIntake = 0;
        }

        public void Eat(Food item)
        {
            if(this.IsFull == true)
            {
                Console.WriteLine("The ninja is full. He cannot eat anymore!");
            }
            else
            {
                this.calorieIntake += item.Calories;
                this.FoodHistory.Add(item);
                Console.WriteLine($"Ninja ate {item.Name}. Spicy? {item.IsSpicy} Sweet? {item.IsSweet}");
            }
        }
    }
}
