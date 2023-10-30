// See https://aka.ms/new-console-template for more information

using System;
using RolePlay;

internal class Program
{
    private static void Main(string[] args)
    //create attacker
    {
        Character attackingChar = Character.UserCreateCharacter();
        attackingChar.DisplayStats();
        Weapon attackweapon = Weapon.CreateSword();
        
        attackingChar.AddHealth(20);
        attackingChar.AddWeapon(attackweapon);


    // create defendingCharer
        Character defendingChar = new Character("bex",20,20,10);
        Weapon defendweapon = Weapon.CreateSword();
        
        defendingChar.AddHealth(20);
        defendingChar.AddWeapon(attackweapon);

       // Character NewChar =  Character.UserCreateCharacter();

        //initiate combat
        
        
        bool playing = true;

        while (playing)
        {
           

            string selected_option = Menu.CombatMenu();

            if (selected_option == "1")
            {
                Combat fight = new Combat(attackingChar, defendingChar);
                fight.DealDamage();
                if (defendingChar.IsAlive == false)
                {
                    playing = false;
                }
            }
            //Console.ReadKey();
            else if (selected_option == "3")
            {
                playing = false;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }

            
        }



    }
        
        
}