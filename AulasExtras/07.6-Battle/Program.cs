/*
Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.
O herói e o monstro começarão com dez pontos de integridade.
Todos os ataques serão um valor entre 1 e 10.
O herói atacará primeiro.
Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
Imprima quem foi o vencedor.
*/

Random ataque = new Random();
int integridadeHeroi = 10;
int integridadeMonstro = 10;
int turnos = 0;

Console.WriteLine($"\t\tTurno {turnos+1}: ");
Console.WriteLine("---------------------------------------------\n");

do {

    if (integridadeHeroi > 0){
    int ataqueHeroi = ataque.Next(11);
    integridadeMonstro -= ataqueHeroi;
    Console.WriteLine($"Heroi causou {ataqueHeroi} de dano");
    Console.WriteLine($"Monstro agora possui {integridadeMonstro} de vida");
    turnos++;
        if (integridadeMonstro > 0){
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine($"\t\tTurno {turnos+1}: ");
            Console.WriteLine("---------------------------------------------\n");
        }
    }

    if (integridadeMonstro <= 0) continue;

    if (integridadeMonstro > 0){
    int ataqueMonstro = ataque.Next(11);
    integridadeHeroi -= ataqueMonstro;
    Console.WriteLine($"Monstro causou {ataqueMonstro} de dano");
    Console.WriteLine($"Heroi possui {integridadeHeroi} de vida");
    turnos++;
        if (integridadeHeroi > 0){
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine($"\t\tTurno {turnos+1}: ");
            Console.WriteLine("---------------------------------------------\n");
        }
    }

} while (integridadeHeroi > 0 && integridadeMonstro > 0);

Console.WriteLine("\n---------------------------------------------");
Console.WriteLine("FIM");
Console.WriteLine("---------------------------------------------");

if (integridadeHeroi > 0){
    Console.WriteLine("Heroi Vence!");
}
else{
    Console.WriteLine("Monstro Vence!");
}