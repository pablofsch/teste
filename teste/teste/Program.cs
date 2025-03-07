// See https://aka.ms/new-console-template for more information
using System;

abstract class Animal
{
    public abstract void EmitirSom();

    public void Dormir()
    {
        Console.WriteLine("O animal está dormindo.");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal meuCachorro = new Cachorro();
        Animal meuGato = new Gato();

        meuCachorro.EmitirSom();
        meuCachorro.Dormir();

        meuGato.EmitirSom();
        meuGato.Dormir();
    }
}
