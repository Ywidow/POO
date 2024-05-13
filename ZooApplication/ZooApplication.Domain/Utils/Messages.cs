namespace ZooApplication.Domain.Utils;

public static class Messages
{
    public static void InitialMenuMessages()
    {
        Console.Clear();
        Console.WriteLine("~~~~ Exercício do Zoológico ~~~~");
        Console.WriteLine("[1] Criar Animal");
        Console.WriteLine("[2] Examinar Animal");
        Console.WriteLine("[3] Percorrer Jaula");
        Console.WriteLine("[4] Sair");
    }

    public static void InvalidMessage()
    {
        Console.Clear();
        Console.WriteLine("Valor inválido...\n\n");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public static void ByeByeMessage()
    {
        Console.Clear();
        Console.WriteLine("Obrigado pela preferência! Volte sempre.");
    }

    public static void AnimalChoose()
    {
        Console.Clear();
        Console.WriteLine("~~~~ Escolha o Animal ~~~~");
        Console.WriteLine("[1] Cachorro");
        Console.WriteLine("[2] Cavalo");
        Console.WriteLine("[3] Preguiça");
    }


}
