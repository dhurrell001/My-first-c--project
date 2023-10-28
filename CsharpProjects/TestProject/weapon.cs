using System;
using System.Dynamic;

namespace RolePlay
{
    class Weapon 
    {
        public string Type {get; private set;}
        private int Damage {get;set;}
        private int Defence {get;set;}

        //constructors
        public Weapon (string name, int damage, int defence)
        {
            Type = name;
            Damage = damage;
            Defence = defence;
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

    }
}