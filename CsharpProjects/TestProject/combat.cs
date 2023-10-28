using System;

namespace RolePlay
{
    class Combat
    {
        public Character Attacker {get;set;}
        public Character Defender {get;set;}
        // constructor

        public Combat(Character attacker,
                      Character defender)
         {
            Attacker = attacker;
            Defender = defender;
        }

        // methods

        public bool DealDamage()
        {   
            int hitDamage = Attacker.EquippedWeapon.Attack();
            int hitDefend = Defender.EquippedWeapon.Defend();
            int attackDamage = hitDamage - hitDefend;
            if (attackDamage>0) {
                Defender.RemoveHealth(hitDamage - hitDefend);
                if (Defender.IsAlive == false)
                {
                    Console.WriteLine($"{Attacker.Name} struck for {hitDamage} points and you failed to defend");
                    Console.WriteLine("** YOU ARE DEAD **");

                    return Defender.IsAlive;
                }
            }
            else
            {
                Defender.RemoveHealth(0);
            }
            Console.WriteLine($"{Attacker.Name} struck for {hitDamage} points");
            Console.WriteLine($"{Defender.Name} defended for {hitDefend} points");
            Console.WriteLine($"{Defender.Name}'s current health is {Defender.Health}");
            return Defender.IsAlive;
            
        }
    }
}