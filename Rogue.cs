using System;

namespace Rpg
{
    // Classe Rogue que herda da classe Character e implementa a interface IStealth
    public class Rogue : Character, IStealth
    {
        // Implementação do método Attack() para a classe Rogue
        public override void Attack()
        {
            // Exibe uma mensagem indicando o ataque do Rogue com seu nome e quantidade de vida
            Console.WriteLine($"{Name} with {Health} of health attacks with daggers.");
        }

        // Implementação do método Stealth() da interface IStealth
        public void Stealth()
        {
            // Exibe uma mensagem indicando que o Rogue está usando a habilidade de furtividade
            Console.WriteLine($"{Name} uses stealth.");
        }
    }
}
