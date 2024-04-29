namespace BankExercise.Utils;

public static class Messages{
    public static void PrintInitialMenu(){
        Console.WriteLine("[1] Criar Conta");
        Console.WriteLine("[2] Depositar Saldo");
        Console.WriteLine("[3] Sacar Saldo");
        Console.WriteLine("[4] Realizar Transferência");
        Console.WriteLine("[5] Emitir Extrato");
        Console.WriteLine("[6] Sair");
        Console.WriteLine("Escolha: ");
    }

    public static void PrintCreateAccountMenu(){
        Console.WriteLine("Qual Tipo de Conta Gostaria de Criar?");
        Console.WriteLine("[1] Com Limite");
        Console.WriteLine("[2] Sem Limite");
        Console.WriteLine("[3] Volta ao Menu");
    }

    public static void PrintAccountCreatedMessage(){
        Console.Clear();

        Console.WriteLine("Sua Conta Foi Criada com Sucesso!");
        Console.WriteLine("\nPressione Qualquer Tecla para Voltar...");

        Console.ReadKey();
        Console.Clear();
    }

    public static void PrintDebitMessage(){
        Console.Clear();

        Console.WriteLine("Seu Valor Foi Debitado Com Sucesso!");
        Console.WriteLine("\nPressione Qualquer Tecla para Voltar...");

        Console.ReadKey();
        Console.Clear();
    }

    public static void PrintWithDrawMessage(){
        Console.Clear();

        Console.WriteLine("Seu Valor Foi Sacado Com Sucesso!");
        Console.WriteLine("\nPressione Qualquer Tecla para Voltar...");

        Console.ReadKey();
        Console.Clear();
    }

    public static void PrintTransfersMessage(){
        Console.Clear();

        Console.WriteLine("Transferência Realizada Com Sucesso!");
        Console.WriteLine("\nPressione Qualquer Tecla para Voltar...");

        Console.ReadKey();
        Console.Clear();
    }

    public static void PrintReturnMessage(){
        Console.Clear();

        Console.WriteLine("Retornando ao Menu...\n");

        Thread.Sleep(2000);
        Console.Clear();
    }

    public static void PrintInvalidMessage(){
        Console.Clear();

        Console.WriteLine("Valor Inválido! Tente Novamente");
        Console.WriteLine("\nPressione Qualquer Tecla para Voltar...");

        Console.ReadKey();
        Console.Clear();
    }

    public static void PrintByeByeMessage(){
        Console.Clear();
        Console.WriteLine("Tchau Tchau! Volte Sempre...");
    }

    public static void FormatExceptionMessage(Exception ex){
        Console.Clear();

        Console.WriteLine(ex.Message);

        Console.WriteLine("\nAperte Qualquer Tecla para Voltar...");
        Console.ReadKey();
        Console.Clear();
    }
}