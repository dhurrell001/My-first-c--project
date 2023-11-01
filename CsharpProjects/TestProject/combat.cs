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
   