using System;

public class Inimigo : Personagem
{
    public string Armadura;
    public string Arma;

    public Inimigo(string nome, int energia, int forcaAtaque, int forcaDoPulo,
        int velocidade, int numeroDePes, int numeroDeMaos,
        string armadura, string arma)
        : base(nome, energia, forcaAtaque, forcaDoPulo, velocidade, numeroDePes, numeroDeMaos)
    {
        Armadura = armadura;
        Arma = arma;
    }

    public override void MostrarStatus()
    {
        base.MostrarStatus();
        Console.WriteLine($"Armadura: {Armadura}");
        Console.WriteLine($"Arma: {Arma}");
    }

    public int DanoDonimigo()
    {
        return 12;
    }
}
