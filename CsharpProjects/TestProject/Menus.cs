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
    public static string ChangeWeapon(Character character) 
    {
        Console.WriteLine("=== Weapon Selction ===");
        Console.WriteLine();
        for (int i = 0; i < character.WeaponsList.Count; i++) 
        {
            Console.WriteLine($"{i+1}: {character.WeaponsList[i].Type}");
        }

        return Console.ReadLine();
        
    }

}
