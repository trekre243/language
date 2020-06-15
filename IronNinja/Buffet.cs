using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            this.Menu = new List<IConsumable>();
            this.Menu.Add(new Food("Pizza", 1000, true, false));
            this.Menu.Add(new Food("Ice Cream", 500, false, true));
            this.Menu.Add(new Drink("Coca Cola", 250, false, true));
            this.Menu.Add(new Drink("Vodka", 300, false, false));
            this.Menu.Add(new Food("Ribs", 750, false, true));
        }

        public IConsumable Serve()
        {
            Random rand = new Random();
            return this.Menu[rand.Next(this.Menu.Count)];
        }
    }
}
