using System;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um novo warrior
            Warrior warrior = new Warrior();
            warrior.Name = "BraveWarrior";
            warrior.Health = 100;

            // Chama o warrior's attack 
            warrior.Attack();

            // Cria um novo mage
            Mage mage = new Mage();
            mage.Name = "PowerfulMage";
            mage.Health = 80;

            // Chama o "mage" attack
            mage.Attack();

            // Cria um novo rogue
            Rogue rogue = new Rogue();
            rogue.Name = "StealthyRogue";
            rogue.Health = 60;

            // Chama o "rogue" attack 
            rogue.Attack();

            // Checa se "rogue" implementa a "IStealth interface"
            if (rogue is IStealth)
            {
                // Chama "rogue" para a IStealth interface
                IStealth stealthRogue = rogue as IStealth;

                // Chama o "stealth" em rogue
                stealthRogue.Stealth();
            }
        }
    }
}
