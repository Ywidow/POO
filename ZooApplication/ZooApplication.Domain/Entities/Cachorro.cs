using ZooApplication.Domain.Abstractions;
using ZooApplication.Domain.Contracts;

namespace ZooApplication.Domain.Entities;

public class Cachorro : Animal, IRunnerAnimal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {

    }

    public override void DoAction() => Console.WriteLine("Cachorro está Correndo");

    public override void MakeSound() => Console.WriteLine("* Som de Cachorro *");
}
