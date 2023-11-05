using System;

namespace RolePlay
{

    
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
                Console.WriteLine($"You struck {defender.Name} causing {hitDamage} points of damage\n");
            }
            else
            {
                Console.WriteLine($"{defender.Name} skillfully blocked your attack\n");
            }

            Console.WriteLine($"{defender.Name}'s current health is {defender.Health}");
            if (!defender.IsAlive)
            {
                Console.WriteLine("\nYou delivered a fatal blow !!");
                Console.WriteLine($"\n==== { defender.Name} is dead. ====");
            }
        }
    }

}
   