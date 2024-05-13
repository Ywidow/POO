using ZooApplication.Domain.Abstractions;
using ZooApplication.Domain.Entities;
using ZooApplication.Domain.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        int menuChoose = 0;

        do
        {
            Messages.InitialMenuMessages();
            try
            {
                menuChoose = int.Parse(Console.ReadKey().KeyChar.ToString());
            }
            catch
            {
                Messages.InvalidMessage();
                continue;
            }

            switch (menuChoose)
            {
                case 1:
                    CreateAnimalMenu();
                    break;
                case 2:
                    ExamineAnimalMenu();
                    break;
                case 3:
                    ZooMenu();
                    break;
                case 4:
                    Messages.ByeByeMessage();
                    break;
                default:
                    Messages.InvalidMessage();
                    break;
            }
        }
        while (menuChoose != 4);
    }

    private static void CreateAnimalMenu()
    {
        int menuChoose;
        bool invalidAnimalChoose;
        Animal animal;
        do
        {
            invalidAnimalChoose = false;
            Messages.AnimalChoose();

            try
            {
                menuChoose = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (menuChoose)
                {
                    case 1:
                        try
                        {
                            animal = CreateDog();
                            MakeAnimalSound(animal);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    case 2:
                        try
                        {
                            animal = CreateHorse();
                            MakeAnimalSound(animal);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    case 3:
                        try
                        {
                            animal = CreateSloths();
                            MakeAnimalSound(animal);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    default:
                        Messages.InvalidMessage();
                        break;
                }
            }
            catch
            {
                Messages.InvalidMessage();
                invalidAnimalChoose = true;
            }
        }
        while (invalidAnimalChoose);
    }

    private static Cachorro CreateDog()
    {
        Console.Clear();
        Console.WriteLine("Nome do Cachorro: ");
        var dogsName = Console.ReadLine();

        Console.WriteLine("Idade do Cachorro: ");
        var dogsAge = int.Parse(Console.ReadLine()!);

        return new Cachorro(dogsName!, dogsAge);
    }

    private static Cavalo CreateHorse()
    {
        Console.Clear();
        Console.WriteLine("Nome do Cavalo: ");
        var horsesName = Console.ReadLine();

        Console.WriteLine("Idade do Cavalo: ");
        var horsesAge = int.Parse(Console.ReadLine()!);

        return new Cavalo(horsesName!, horsesAge);
    }

    private static Preguica CreateSloths()
    {
        Console.Clear();
        Console.WriteLine("Nome da Preguiça: ");
        var slothsName = Console.ReadLine();

        Console.WriteLine("Idade da Preguiça: ");
        var slothsAge = int.Parse(Console.ReadLine()!);

        return new Preguica(slothsName!, slothsAge);
    }

    private static void MakeAnimalSound(Animal animal)
    {
        Console.Clear();
        Console.WriteLine("~~~~ Barulho do Animal ~~~~");
        animal.MakeSound();

        Console.WriteLine("\n\nPressione qualque tecla para continuar...");
        Console.ReadKey();
    }

    private static void ExamineAnimalMenu()
    {
        int menuChoose;
        bool invalidAnimalChoose;
        Veterinario veterinario = new();
        do
        {
            invalidAnimalChoose = false;
            Messages.AnimalChoose();

            try
            {
                menuChoose = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (menuChoose)
                {
                    case 1:
                        try
                        {
                            var dog = new Cachorro("Cachorro para Examinar", 8);
                            veterinario.Examinar(dog);
                            MakeAnimalSound(dog);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    case 2:
                        try
                        {
                            var horse = new Cavalo("Cavalo para Examinar", 3);
                            veterinario.Examinar(horse);
                            MakeAnimalSound(horse);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    case 3:
                        try
                        {
                            var sloth = new Preguica("Preguica para Examinar", 5);
                            veterinario.Examinar(sloth);
                            MakeAnimalSound(sloth);
                        }
                        catch
                        {
                            Messages.InvalidMessage();
                        }
                        break;
                    default:
                        Messages.InvalidMessage();
                        break;
                }
            }
            catch
            {
                Messages.InvalidMessage();
                invalidAnimalChoose = true;
            }
        }
        while (invalidAnimalChoose);
    }

    private static void ZooMenu()
    {
        Console.Clear();
        Console.WriteLine("~~~~ Percorrendo Jaula ~~~~\n");

        var zoo = new Zoo();

        zoo.BrowseCages();

        Console.WriteLine("\n\n");
        Console.ReadKey();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
    }
}