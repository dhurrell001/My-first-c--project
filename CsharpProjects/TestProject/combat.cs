using System;

namespace RolePlay
{

    // In the Combat class
    public class Combat
    {
        public static void DealDamage(Character attacker, Character defender)
        {
            int hitDamage = attacker.EquippedWeapon.Attack();
            int hitDefend = defender.EquippedWeapon.Defend();
            int attackDamage = hitDamage - hitDefend;

            if (attackDamage > 0)
            {
                defender.RemoveHealth(attackDamage);
                Console.WriteLine($"{attacker.Name} struck for {hitDamage} points");
            }
            else
            {
                Console.WriteLine($"{attacker.Name} couldn't penetrate {defender.Name}'s defense");
            }

            Console.WriteLine($"{defender.Name}'s current health is {defender.Health}");
            if (!defender.IsAlive)
            {
                Console.WriteLine($"{defender.Name} is dead.");
            }
        }
    }

}
    //class Combat
    //{
    //    public Character Attacker {get;set;}
    //    public Character Defender {get;set;}
    //    // constructor

    //    public Combat(Character attacker,
    //                  Character defender)
    //    {
    //        Attacker = attacker;
    //        Defender = defender;
    //    }

        // methods

        //public void Fight()
        //{
        //    while (Attacker.IsAlive && Defender.IsAlive)
        //    {
        //        Attacker.DealDamage();
        //        Console.WriteLine();
        //        Defender.DealDamage();
        //    }
        //}

        //public bool DealDamage()
        //{   
        //    int hitDamage = Attacker.EquippedWeapon.Attack();
        //    int hitDefend = Defender.EquippedWeapon.Defend();
        //    int attackDamage = hitDamage - hitDefend;
        //    if (attackDamage>0) {
        //        Defender.RemoveHealth(hitDamage - hitDefend);
        //        if (Defender.IsAlive == false)
        //        {
        //            Console.WriteLine($"{Attacker.Name} struck for {hitDamage} points and you failed to defend");
        //            Console.WriteLine("** YOU ARE DEAD **");
        //            Defender.IsAlive = false;
        //            return Defender.IsAlive;
        //        }
        //    }
        //    else
        //    {
        //        Defender.RemoveHealth(0);
        //    }
        //    Console.WriteLine($"{Attacker.Name} struck for {hitDamage} points");
        //    Console.WriteLine($"{Defender.Name} defended for {hitDefend} points");
        //    Console.WriteLine($"{Defender.Name}'s current health is {Defender.Health}");
        //    return Defender.IsAlive;
            
//        }
//    }
//}