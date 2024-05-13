using ZooApplication.Domain.Abstractions;

namespace ZooApplication.Domain.Entities;

public class Cavalo : Animal, IRunnerAnimal
{
    public Cavalo(string nome, int idade) : base(nome, idade)
    {

    }

    public override void DoAction() => Console.WriteLine("Cavalo está Correndo");

    public override void MakeSound() => Console.WriteLine("* Som de Cavalo *");
}
