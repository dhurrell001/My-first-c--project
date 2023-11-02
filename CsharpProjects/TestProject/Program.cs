// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
using RolePlay;

internal class Program
{
    private static void Main(string[] args)
   
    {
       
        Character PlayerOne = null;
        Character PlayerTwo = null;
        bool running = true;

        while (running)
        {
            string startOption = Menu.MainMenu();

            switch (startOption)
            {
                case "1":
                    Console.Clear();    
                    Console.WriteLine("Player One create your character");
                    PlayerOne = Character.UserCreateCharacter();              
                    Console.ReadLine();
                    Console.Clear();    
                    Console.WriteLine("Player Two create your character");
                    PlayerTwo = Character.UserCreateCharacter();                  

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    if (PlayerOne != null && PlayerTwo != null)
                    {
                        PlayGame(PlayerOne, PlayerTwo);
                        break;
                    }
                    break;
                   
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        }

    }

    private static void PlayGame(Character playerOne, Character playerTwo)

    {
        Character attackingChar;
        Character defendingChar;

        if (playerOne.Speed > playerTwo.Speed)
        {
            attackingChar = playerOne;
            defendingChar = playerTwo;
            Console.WriteLine($"{attackingChar.Name} goes first !!\n");

        }
        else
        {
            attackingChar = playerTwo;
            defendingChar = playerOne;
            Console.WriteLine($"{attackingChar.Name} goes first !!\n");
        }

        bool playing = true;
        while (playing)
        {

            if (defendingChar.IsAlive == false || attackingChar.IsAlive == false)
            {
                playing = false;
                Console.WriteLine("******* GAME OVER *********");
                Console.ReadLine(); 
                Menu.MainMenu();
                break;
            }
            Console.WriteLine($"==== {attackingChar.Name}'s Turn ====\n");
            string selected_option = Menu.CombatMenu();  

            if (selected_option == "1")
            {
                     
                Combat.DealDamage(attackingChar, defendingChar);
                (attackingChar, defendingChar) = (defendingChar, attackingChar);
                Console.ReadLine();
                Console.Clear();
            }
               

            
            //Console.ReadKey();
            else if (selected_option == "2")
            {
                Menu.ChangeWeapon(attackingChar); 
                break;
            }
            else if (selected_option == "3")
            {
                playing = false;
                break;
            }
            else if (selected_option == "4")
            {
                Console.Clear();
                attackingChar.DisplayStats();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }


        }
    }
        
        
}