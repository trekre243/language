using System;
using System.Collections.Generic;

namespace WizNinjSam
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
            set { this.health = value; }
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

        public virtual int Attack(Human target)
        {
            int damage = 5 * this.Strength;
            target.health -= damage;
            return target.health;
        }

    }

    public class Wizard : Human
    {
        public Wizard(string name, int strength, int dexterity) :
         base(name, strength, 25, dexterity, 50)
        {
            
        }

        public override int Attack(Human target)
        {
            int damage = 5 * this.Intelligence;
            target.Health -= damage;
            this.Health += damage;
            return target.Health;
        }

        public int Heal(Human target)
        {
            int healAmt = 10 * this.Intelligence;
            target.Health += healAmt;
            return target.Health;
        }
    }

    public class Ninja : Human
    {
        public Ninja(string name, int strength, int intelligence, int health) :
         base(name, strength, intelligence, 175, health)
         {

         }

         public override int Attack(Human target)
         {
             int damage = 5 * this.Dexterity;

             Random rand = new Random();
            if(rand.Next(5) == 1)
            {
                damage += 10;
            }

            target.Health -= damage;
            return target.Health;

         }

         public int Steal(Human target)
         {
             target.Health -= 5;
             this.Health += 5;
             return target.Health;
         }
    }

    public class Samurai : Human
    {
        public Samurai(string name, int strength, int intelligence, int dexterity) :
         base(name, strength, intelligence, dexterity, 200)
        {

        }

        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                target.Health = 0;
                return 0;
            }
            else
            {
                return base.Attack(target);
            }
        }

        public int Meditate()
        {
            this.Health = 200;
            return this.Health;
        }
    }
}
