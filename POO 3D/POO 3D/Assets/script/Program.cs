using System;

class Program
{
    static void Main(string[] args)
    {
        Personagem heroi = new Personagem("Herói", 100, 20, 15, 10, 2, 2);
        Inimigo inimigo = new Inimigo("Goblin", 80, 15, 10, 8, 2, 2, "Couro", "Espada");

        Personagem u = new Personagem();
        
        heroi.MostrarStatus();
        inimigo.MostrarStatus();

        Console.WriteLine("\n--- BATALHA ---");
        heroi.Atacar(inimigo);
        inimigo.Atacar(heroi);
        heroi.Pular();
        inimigo.Pular();
    }
}