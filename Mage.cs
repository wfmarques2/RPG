using System;

namespace Rpg
{
    public class Mage : Character
    {
        // Implementação do método Attack() para a classe Mage
        public override void Attack()
        {
            // Exibe uma mensagem indicando o ataque do Mage com seu nome e quantidade de vida
            Console.WriteLine($"{Name} with {Health} of health attacks with fireballs.");
        }
    }
}
