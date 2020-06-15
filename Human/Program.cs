using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human trevor = new Human("Trevor");
            Console.WriteLine($"Name: {trevor.Name}");
            Console.WriteLine($"Strength: {trevor.Strength}");
            Console.WriteLine($"Intelligence: {trevor.Intelligence}");
            Console.WriteLine($"Dexterity: {trevor.Dexterity}");
            Console.WriteLine($"Health: {trevor.Health}");

            Human attackee = new Human("Johnathon", 2, 1, 5, 100);
            Console.WriteLine($"Name: {attackee.Name}");
            Console.WriteLine($"Strength: {attackee.Strength}");
            Console.WriteLine($"Intelligence: {attackee.Intelligence}");
            Console.WriteLine($"Dexterity: {attackee.Dexterity}");
            Console.WriteLine($"Health: {attackee.Health}");

            trevor.Attack(attackee);
            Console.WriteLine($"Name: {attackee.Name}");
            Console.WriteLine($"Strength: {attackee.Strength}");
            Console.WriteLine($"Intelligence: {attackee.Intelligence}");
            Console.WriteLine($"Dexterity: {attackee.Dexterity}");
            Console.WriteLine($"Health: {attackee.Health}");
        }
    }

    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return this.health; }
        }

        public Human(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.health = health;
        }

        public int Attack(Human target)
        {
            int damage = 5 * this.Strength;
            target.health -= damage;
            return target.Health;
        }

    }
}
