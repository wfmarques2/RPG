#Mini Desafio de Interfaces e Classes Abstratas

Estamos desenvolvendo um jogo de RPG para se passar no mundo de Lazeroth, neste mundo existem três tipos de personagens possíveis para o jogador escolher:

Warrior
Mage
Rogue

Cada personagem tem um nome e uma quantidade de pontos de vida (HP). Além disso cada personagem pode realizar um ataque, porém o tipo de ataque varia com base na classe do personagem.

Warriors atacam com swords;
Mages atacam com fireballs;
Rogues atacam com daggers, e além disso podem usar furtividade.

Para o desafio você deve:

Implementar uma classe abstrata Character que inclua propriedades para o Name (string) e Health (int), e um método abstrato Attack(). [1,2]
Implementar as classes Warrior, Mage e Rogue, que herdam da classe Character e implementam o método Attack() de forma adequada. [1,2]
Implementar uma interface IStealth que inclua um método Stealth(). [2,1]
A classe Rogue deve implementar a interface IStealth, além de herdar da classe Character. [1,2]
No método Main, crie um objeto para cada classe de personagem e invoque o método Attack() para cada um. [1,3]
Para o objeto Rogue, verifique se implementa IStealth e, em caso afirmativo, invoque o método Stealth(). [2,1]