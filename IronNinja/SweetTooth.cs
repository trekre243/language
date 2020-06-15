using System;

namespace IronNinja
{
    public class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get { return calorieIntake > 1500; }
        }

        public override void Consume(IConsumable item)
        {
            if(IsFull)
            {
                Console.WriteLine("SweetTooth is full and cannot eat anymore.");
            }
            else
            {
                calorieIntake += item.Calories;
                if(item.IsSweet)
                {
                    calorieIntake += 10;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.getInfo());
            }
        }
    }
}