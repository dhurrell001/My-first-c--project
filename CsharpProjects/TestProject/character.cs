using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace RolePlay
{

    class Character
    {
        public string Name {get;set;}
        public int Strength{get; private set;}
        public int Health {get;  set;}
        public bool IsAlive { get ; set;}

        public Weapon EquippedWeapon {get;set;} 
        // Constructors

        public Character(string name)
        {
            Name = name;
            EquippedWeapon = new Weapon("Fist",3,3);
            IsAlive = true;
        }
        public Character (string name, int strength,int health)
        {
            Name = name;
            Strength = strength;
            Health = health;
            IsAlive = true;
            EquippedWeapon = new Weapon("Fist", 3, 3);
        }

        //Methods

        public void AddHealth(int health) => Health += health;

        public bool RemoveHealth(int health)
        // return true or false for 'is alive'
        {
            Health -= health;
            if (Health <= 0)
            {
                IsAlive = false; 
                return false;
            }
            else
            {
                 Console.WriteLine($"You took {health} damage");
                 IsAlive = true;
                 return true;
            }
            
        }
        public void AddWeapon(Weapon weapon) => EquippedWeapon = weapon;
    }
}