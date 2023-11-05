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
                    // Create character option selected
                    Console.Clear();    
                    Console.WriteLine("Player One create your character");
                    PlayerOne = Character.UserCreateCharacter();  
                    ClearConsoleAndPause();
                    //Console.ReadLine();
                    //Console.Clear();    
                    Console.WriteLine("Player Two create your character");
                    PlayerTwo = Character.UserCreateCharacter();
                    ClearConsoleAndPause();

                    //Console.ReadLine();
                    //Console.Clear();
                    break;
                case "2":
                    // Start gane option selected. Checks that characters exist before starting game
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
        // Start gameplay logic.

    {
        Character attackingChar;
        Character defendingChar;

        (attackingChar, defendingChar) = DetermineFirstPlayer(playerOne, playerTwo);
        Console.WriteLine($"{attackingChar.Name} goes first !!\n");

        


        bool playing = true;
        while (playing)
        {
            // check if both players are aliveif either is dead game is over. TODO change to allow for a play again option

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
            // Attack option selected. Passes characters to Deal damage method in combat class
            // switches players so defender becomes attacker for next turn
            {

                Combat.DealDamage(attackingChar, defendingChar);
                (attackingChar, defendingChar) = (defendingChar, attackingChar); 
                ClearConsoleAndPause(); 

            }
               

            else if (selected_option == "2")
                // Change weapon option selected.
            {
                string weaponSelectOption = Menu.ChangeWeaponMenu(attackingChar); 
                // Change equipped weapom TODO maybe use weaponSelectOption result as an index so it is not hardcoded

                switch (weaponSelectOption)
                {
                    case "1":
                        attackingChar.EquippedWeapon = attackingChar.WeaponsList[0];
                        break;
                    case "2":
                        attackingChar.EquippedWeapon = attackingChar.WeaponsList[1];
                        break;
                    case "3":
                        attackingChar.EquippedWeapon = attackingChar.WeaponsList[2];
                        break;
                    default:
                        Console.WriteLine("Please enter a vaild option");
                        break;
                }
                continue; // carry on in combatMenu not 'break' back to main menu
            }
            else if (selected_option == "3")
                // Quit combat option selected
            {
                playing = false;
                break;
            }
            else if (selected_option == "4")
                // Display character statistics using DisplayStats method in Character class.
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
    private static void ClearConsoleAndPause()
        // Waits for user to press a key before clearing console
    {
        Console.ReadLine();
        Console.Clear();
    }
    private static (Character, Character) DetermineFirstPlayer(Character playerOne, Character playerTwo)

    // Calculate which player attacks first based on speed property
    // and assign as defender and attacker
    {
        Character attackingChar, defendingChar;

        if (playerOne.Speed > playerTwo.Speed)
        {
            attackingChar = playerOne;
            defendingChar = playerTwo;
        }
        else
        {
            attackingChar = playerTwo;
            defendingChar = playerOne;
        }

        return (attackingChar, defendingChar);
    }

}