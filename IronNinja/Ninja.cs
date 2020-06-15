using System;
using System.Collections.Generic;

namespace IronNinja
{
    public abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public abstract bool IsFull {get;}
        public abstract void Consume(IConsumable item);
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
    }
}