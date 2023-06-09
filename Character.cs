using System;

namespace Rpg
{
    // Classe abstrata base para personagens
    public abstract class Character
    {
        // O nome do personagem. Pode ser nulo.
        public string? Name { get; set; } 
        
        // A quantidade de pontos de vida do personagem.
        public int Health { get; set; }

        // Método abstrato que define a ação de ataque do personagem.
        public abstract void Attack();
    }
}
