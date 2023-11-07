using System;
using RolePlay;

public class Menu
{
	public static string CombatMenu()

	{
        //Console.Clear();    
        Console.WriteLine("==== Select an option ====");
        Console.WriteLine("1: Attack");
        Console.WriteLine("2: Change Weapon");
        Console.WriteLine("3: Exit");
        Console.WriteLine("4: Display Stats");
        
        return Console.ReadLine();
    }   
    
    public static string MainMenu()
    {
        Console.Clear();
        Console.WriteLine("=== MAIN MENU ===");
        Console.WriteLine("==== Select an option ====");
        Console.WriteLine("1: Create a new characeter");
        Console.WriteLine("2: Start game");
        Console.WriteLine("3: Quit");
        

        return Console.ReadLine(); 
    }
    public static int ChangeWeaponMenu(Character character) 
    {
        Console.WriteLine("=== Weapon Selection ===");
        Console.WriteLine();
        for (int i = 0; i < character.WeaponsList.Count; i++) 
        {
            Console.WriteLine($"{i+1}: {character.WeaponsList[i].Type}  " +
                $"Damage : {character.WeaponsList[i].Damage} Defence : {character.WeaponsList[i].Defence} " +
                $"Speed : {character.WeaponsList[i].Speed}\n");
        }
        int choice;

        if (int.TryParse(Console.ReadLine(), out choice) && choice >=1 && choice <= character.WeaponsList.Count)
        {
            return choice - 1;
        }

        Console.WriteLine("Please enter a valid choice");
        return ChangeWeaponMenu(character);

    }

}
