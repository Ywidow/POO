using ZooApplication.Domain.Abstractions;

namespace ZooApplication.Domain.Entities;

public class Preguica : Animal
{
    public Preguica(string nome, int idade) : base(nome, idade)
    {
        
    }

    public override void DoAction() => Console.WriteLine("Preguiça está Subindo Árvore");

    public override void MakeSound() => Console.WriteLine("* Som de Preguiça *");
}
