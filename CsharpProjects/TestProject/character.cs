using System;
using System.Dynamic;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;



namespace RolePlay
{

    public class Character
    {
        public string Name {get;set;}
        public int Strength{get; private set;}
        public int Health {get;  set;}
        public int Speed { get; set;}
        public bool IsAlive { get ; set;}
        public List<Weapon> WeaponsList { get; set; } //create a list to store weapons



        public Weapon EquippedWeapon {get;set;} 
        // Constructors

        public Character(string name)
        {
            Name = name;
            EquippedWeapon = new Weapon("Fist",3,3,1);
            IsAlive = true;
            WeaponsList = new List<Weapon>(); ;
        }
        public Character (string name, int strength,int health,int speed)
        {
            Name = name;
            Strength = strength;
            Health = health;
            IsAlive = true;
            Speed = speed;
            WeaponsList =  new List<Weapon>();
            EquippedWeapon = new Weapon("Fist", 3, 3,1);
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
                 //Console.WriteLine($"You took {health} damage");
                 IsAlive = true;
                 return true;
            }
            
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Strength : {Strength}");
            Console.WriteLine($"Health : {Health}");
            Console.WriteLine($"Speed : {Speed}");
            Console.WriteLine("=== Weapons ===");
            for (int i = 0; i < WeaponsList.Count; i++)
            {
                Console.WriteLine($"{WeaponsList[i].Type} Damage : {WeaponsList[i].Damage} Defence : {WeaponsList[i].Defence} Speed : {WeaponsList[i].Speed}");
                
            }
        }
        public void AddWeapon(Weapon weapon) => EquippedWeapon = weapon;


        public static Character UserCreateCharacter()
        {

            string charName = "";

            //create a random numbe object
            Random roll = new Random();

            //create a loop to make sure empmty name string is not entered
            while (string.IsNullOrEmpty(charName))
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your character name:");
                charName = Console.ReadLine().Trim(); // Trim leading/trailing whitespace

                if (string.IsNullOrEmpty(charName))
                {
                    Console.WriteLine("Character name cannot be empty. Please try again.");
                }
            };
            
            int strength = roll.Next(1, 20);
            int health = roll.Next(1, 20);
            int speed = roll.Next(1, 20);

      
            Character character =  new Character(charName, strength, health,speed);

            character.WeaponsList.Add(Weapon.CreateDagger());
            character.WeaponsList.Add(Weapon.CreateSword());
            character.WeaponsList.Add(Weapon.CreateHammer());

            Console.WriteLine("Character created");
            Console.WriteLine();
            character.DisplayStats();

            return character;
        }

    }
}

