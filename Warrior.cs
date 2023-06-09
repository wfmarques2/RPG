using System;

namespace Rpg
{
    public class Warrior : Character
    {
        // Implementação do método Attack() para a classe Warrior
        public override void Attack()
        {
            // Exibe uma mensagem indicando o ataque do Warrior com seu nome e quantidade de vida
            Console.WriteLine($"{Name} with {Health} of health attacks with swords.");
        }
    }
}
