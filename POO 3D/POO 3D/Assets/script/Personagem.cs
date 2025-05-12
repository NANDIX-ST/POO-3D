using System;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    public string Nome;
    [ SerializeField ]
    public int Energia;
    [ SerializeField ]
    public int ForcaAtaque;
    [ SerializeField ]
    public int ForcaDoPulo;
    [ SerializeField ]
    public int Velocidade; 
    [ SerializeField ]
    public int NumeroDePes;
    [ SerializeField ]
    public int NumeroDeMaos;
    [ SerializeField ]
    public Personagem() {}

public Personagem(string nome, int energia, int forcaAtaque, int forcaDoPulo,
                      int velocidade, int numeroDePes, int numeroDeMaos)
    {
        Nome = nome;
        Energia = energia;
        ForcaAtaque = forcaAtaque;
        ForcaDoPulo = forcaDoPulo;
        Velocidade = velocidade;
        NumeroDePes = numeroDePes;
        NumeroDeMaos = numeroDeMaos;
        
    }

    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }
    public string NomeDoPersonagem()
    {
        return this.Nome;
    }
    public void AtribuirEnergia(int energia)
    {
        this.Energia = energia;
    }

    public int EnergiaDoPersonagem()
    {
        return this.Energia;
    }

    public void AtribuirForcaAtaque(int forcaAtaque)
    {
        this.ForcaAtaque = forcaAtaque;
    }

    public int ForcaAtaqueDoPersonagem()
    {
        return this.ForcaAtaque;
    }

    public void AtribuirForcaDoPulo(int forcaDoPulo)
    {
        this.ForcaDoPulo = forcaDoPulo;
    }

    public int ForcaDoPuloDoPersonagem()
    {
        return this.ForcaDoPulo;
    }

    public void AtribuirVelocidade(int velocidade)
    {
        this.Velocidade = velocidade;
    }

    public int VelocidadeDoPersonagem()
    {
        return this.Velocidade;
    }

    public void AtribuirNumeroDePes(int numeroDePes)
    {
        this.NumeroDePes = numeroDePes;
    }

    public int NumeroDePesDoPersonagem()
    {
        return this.NumeroDePes;
    }

    public void AtribuirNumeroDeMaos(int numeroDeMaos)
    {
        this.NumeroDeMaos = numeroDeMaos;
    }

    public int NumeroDeMaosDoPersonagem()
    {
        return this.NumeroDeMaos;
    }

    public virtual void MostrarStatus()
    {
        Console.WriteLine($"=== STATUS DE {Nome.ToUpper()} ===");
        Console.WriteLine($"Energia: {Energia}");
        Console.WriteLine($"Força de Ataque: {ForcaAtaque}");
        Console.WriteLine($"Força do Pulo: {ForcaDoPulo}");
        Console.WriteLine($"Velocidade: {Velocidade}");
        Console.WriteLine($"Número de Pés: {NumeroDePes}");
        Console.WriteLine($"Número de Mãos: {NumeroDeMaos}");
    }

    public void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{Nome} atacou {alvo.Nome} com força {ForcaAtaque}");
        alvo.ReceberDano(ForcaAtaque);
    }

    public void Pular()
    {
        Console.WriteLine($"{Nome} pulou com força {ForcaDoPulo}");
    }

    public void ReceberDano(int dano)
    {
        Energia -= dano;
        if (Energia < 0) Energia = 0;
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Energia restante: {Energia}");
    }
}