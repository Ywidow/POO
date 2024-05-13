using ZooApplication.Domain.Contracts;

namespace ZooApplication.Domain.Abstractions;

public abstract class Animal : IAnimalActions
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract void DoAction();

    public abstract void MakeSound();
}
