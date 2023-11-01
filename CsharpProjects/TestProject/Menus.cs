using System;

public class Menu
{
	public static string CombatMenu()
	{
        Console.WriteLine("==== Select an option ====");
        Console.WriteLine("1: Attack");
        Console.WriteLine("2: Change Weapon");
        Console.WriteLine("3: Exit");
        Console.WriteLine("4: Display Stats");
        
        return Console.ReadLine();
    }   
    
    public static string MainMenu()
    {
        Console.WriteLine("=== MAIN MENU ===");
        Console.WriteLine("==== Select an option ====");
        Console.WriteLine("1: Create a new characeter");
        Console.WriteLine("2: Start game");
        Console.WriteLine("3: Quit");
        

        return Console.ReadLine(); 
    }
}
