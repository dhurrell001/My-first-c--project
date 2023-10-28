// See https://aka.ms/new-console-template for more information

using System;
using RolePlay;

internal class Program
{
    private static void Main(string[] args)
    //create attacker
    {
        Character attack = new Character("dave",10,10);
        Weapon attackweapon = new Weapon("sword",20,10);
        
        attack.AddHealth(20);
        attack.AddWeapon(attackweapon);


    // create defender
        Character defend = new Character("bex",20,20);
        Weapon defendweapon = new Weapon("axe",20,10);
        
        defend.AddHealth(20);
        defend.AddWeapon(attackweapon);

        //initiate combat
        
        
        bool playing = true;

        while (playing)
        {
           /* Console.WriteLine("-- Select an option --");
            Console.WriteLine();
            Console.WriteLine("Press 1 to attack");
            Console.WriteLine("Press 2 to quit");*/

            string selected_option = Menu.CombatMenu();

            if (selected_option == "1")
            {
                Combat fight = new Combat(attack, defend);
                fight.DealDamage();
                if (defend.IsAlive == false)
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

            
        }



    }
        
        
}