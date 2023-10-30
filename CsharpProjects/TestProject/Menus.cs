using System;

public class Menu
{
	public static string CombatMenu()
	{
        Console.WriteLine("==== Select an option ====");
        Console.WriteLine("1: Attack");
        Console.WriteLine("2: Change Weapon");
        Console.WriteLine("3: Exit");
        
        return Console.ReadLine();
    }   
}
