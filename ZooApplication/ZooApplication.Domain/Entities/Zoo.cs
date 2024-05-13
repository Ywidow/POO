using ZooApplication.Domain.Abstractions;

namespace ZooApplication.Domain.Entities;

public class Zoo
{
    public Animal[] Jaulas { get; set; } = new Animal[10];

    public Zoo()
    {
        Jaulas[0] = new Cachorro("Cachorro 1", 3);
        Jaulas[1] = new Cavalo("Cavalo 1", 3);
        Jaulas[2] = new Preguica("Preguica 1", 3);
        Jaulas[3] = new Cachorro("Cachorro 2", 3);
        Jaulas[4] = new Cavalo("Cavalo 2", 3);
        Jaulas[5] = new Preguica("Preguica 2", 3);
        Jaulas[6] = new Cachorro("Cachorro 3", 3);
        Jaulas[7] = new Cavalo("Cavalo 3", 3);
        Jaulas[8] = new Preguica("Preguica 3", 3);
        Jaulas[9] = new Cachorro("Cachorro 4", 3);
    }

    public void BrowseCages()
    {
        foreach(var animal in Jaulas)
        {
            Console.WriteLine(animal.Nome + ": ");
            Console.Write("\n Som: ");
            animal.MakeSound();

            if (animal.GetType().IsAssignableTo(typeof(IRunnerAnimal)))
            {
                Console.Write("\n Ação: ");
                animal.DoAction();
            }

            Console.WriteLine();
        }
    }
}
