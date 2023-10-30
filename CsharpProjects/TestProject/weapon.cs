using System;
using System.Dynamic;

namespace RolePlay
{
    class Weapon 
    {
        public string Type {get; private set;}
        private int Damage {get;set;}
        private int Defence {get;set;}
        private int Speed { get;set;}

        //constructors
        public Weapon (string name, int damage, int defence, int speed)
        {
            Type = name;
            Damage = damage;
            Defence = defence;
            Speed = speed;
        }
        public int Attack()
        {
            Random roll = new Random();
            int hitDamage = roll.Next(1,Damage);
            //Console.WriteLine($"You struck for {hitDamage} points");
            return hitDamage;

        }
        public int Defend()
        {
            Random roll = new Random();
            int hitDefend = roll.Next(0,Defence);
            return hitDefend;
        }

        // static methods to create individual weapons

        public static Weapon CreateSword()
        {
            Random roll = new Random();

            string type = "Sword";
            int damage = roll.Next(1, 20);
            int defence = roll.Next(1, 20);
            int speed = roll.Next(1, 20);

            return new Weapon(type, damage, defence, speed);




        }

    }
}