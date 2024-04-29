using System.ComponentModel;
using BankExercise.Utils;
using Br.Univali.Cc.Prog3.Banco;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("~~~~~~ Bem-vindo ao Thomy's Bank ~~~~~~");

        var bank = new Banco();
        int menuChoose;
        do{
            Messages.PrintInitialMenu();
            menuChoose = Readers.ReadMenuChoose();

            switch (menuChoose){
                case 1:
                    CreateAccountCase(bank);
                    break;
                case 2:
                    DepositCase(bank);
                    break;
                case 3:
                    WithDrawCase(bank);
                    break;
                case 4:
                    TransfersCase(bank);
                    break;
                case 5:
                    ExtractCase(bank);
                    break;
                case 6:
                    Messages.PrintByeByeMessage();
                    break;
                default:
                    Messages.PrintInvalidMessage();
                    break;
            }
        }
        while (menuChoose != 6);
    }

    private static void ExtractCase(Banco bank){
        try{
            var extract = GetExtractFromAccount(bank);

            PrintExtract(extract);
        }
        catch (FormatException){
            Messages.PrintInvalidMessage();
        }
        catch (ArgumentNullException ex){
            Messages.FormatExceptionMessage(ex);
        }
        catch (ArgumentException ex){
            Messages.FormatExceptionMessage(ex);
        }
    }

    private static string GetExtractFromAccount(Banco bank){
        Console.Clear();

        Console.Write("Digite o Número da sua Conta: ");

        var originNumberAccount = Readers.ReadIntValue();

        return bank.EmitirExtrato(originNumberAccount);
    }

    private static void PrintExtract(string extract){
        Console.Clear();

        Console.WriteLine("~~~~~~ Extrato Emitido ~~~~~~");
        Console.WriteLine(extract);

        Console.WriteLine("\n Pressione Qualquer Tecla para Retornar.");

        Console.ReadKey();
        Console.Clear();
    }

    private static void TransfersCase(Banco bank){
        try{
            Console.Clear();

            Console.Write("Digite o Número da Conta de Origem: ");
            var originNumberAccount = Readers.ReadIntValue();

            Console.Write("Digite o Número da Conta de Destino: ");
            var destinyNumberAccount = Readers.ReadIntValue();

            Console.Write("Digite o Valor a Sacar: ");
            var depositValue = Readers.ReadDoubleValue();

            bank.Transferir(originNumberAccount, destinyNumberAccount, depositValue);

            Messages.PrintTransfersMessage();
        }
        catch (FormatException){
            Messages.PrintInvalidMessage();
        }
        catch (ArgumentNullException ex){
            Messages.FormatExceptionMessage(ex);
        }
        catch (ArgumentException ex){
            Messages.FormatExceptionMessage(ex);
        }

    }

    private static void WithDrawCase(Banco bank){
        try{
            Console.Clear();

            Console.Write("Digite o Número da sua Conta: ");
            var numberAccount = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o Valor a Sacar: ");
            var depositValue = double.Parse(Console.ReadLine()!);

            bank.Sacar(numberAccount, depositValue);

            Messages.PrintWithDrawMessage();
        }
        catch (FormatException){
            Messages.PrintInvalidMessage();
        }
        catch (ArgumentNullException ex){
            Messages.FormatExceptionMessage(ex);
        }
        catch (ArgumentException ex){
            Messages.FormatExceptionMessage(ex);
        }
    }

    private static void DepositCase(Banco bank){
        try{
            Console.Clear();

            Console.Write("Digite o Número da sua Conta: ");
            var numberAccount = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o Valor a Depositar: ");
            var depositValue = double.Parse(Console.ReadLine()!);

            bank.Depositar(numberAccount, depositValue);

            Messages.PrintDebitMessage();
        }
        catch (FormatException){
            Messages.PrintInvalidMessage();
        }
        catch (ArgumentNullException ex){
            Messages.FormatExceptionMessage(ex);
        }
        catch (ArgumentException ex){
            Messages.FormatExceptionMessage(ex);
        }
    }

    private static void CreateAccountCase(Banco bank){
        Console.Clear();

        int menuChoose;
        do{
            Messages.PrintCreateAccountMenu();

            menuChoose = Readers.ReadMenuChoose();

            switch (menuChoose){
                case 1:
                    CreateSpecialAccount(bank);
                    return;
                case 2:
                    CreateNormalAccount(bank);
                    return;
                case 3:
                    Messages.PrintReturnMessage();
                    return;
                default:
                    Messages.PrintInvalidMessage();
                    break;
            }
        }
        while (menuChoose != 3);
    }

    private static void CreateNormalAccount(Banco bank){
        bool valueWritedIsInvalid;
        do{
            try{
                Console.Clear();
                valueWritedIsInvalid = false;

                Console.Write("Digite seu Saldo Inicial: ");
                var openingBalance = Readers.ReadDoubleValue();

                bank.CriarConta(openingBalance);
            }
            catch(ArgumentNullException ex){
                valueWritedIsInvalid = true;
                Messages.FormatExceptionMessage(ex);
            }
            catch (ArgumentException ex){
                valueWritedIsInvalid = true;
                Messages.FormatExceptionMessage(ex);
            }
            catch (FormatException){
                valueWritedIsInvalid = true;
                Messages.PrintInvalidMessage();
            }
        }
        while (valueWritedIsInvalid);

        Messages.PrintAccountCreatedMessage();
    }

    private static void CreateSpecialAccount(Banco bank){
        bool valueWritedIsInvalid;
        do{
            try{
                Console.Clear();
                valueWritedIsInvalid = false;

                Console.Write("Digite seu Saldo Inicial: ");               
                var openingBalance = Readers.ReadDoubleValue();

                Console.Write("Digite seu Limite: ");
                var limit = Readers.ReadDoubleValue();

                bank.CriarConta(openingBalance, limit);
            }
            catch(ArgumentNullException ex){
                valueWritedIsInvalid = true;
                Messages.FormatExceptionMessage(ex);
            }
            catch (ArgumentException ex)
            {
                valueWritedIsInvalid = true;
                Messages.FormatExceptionMessage(ex);
            }
            catch (FormatException)
            {
                valueWritedIsInvalid = true;
                Messages.PrintInvalidMessage();
            }
        }
        while (valueWritedIsInvalid);

        Messages.PrintAccountCreatedMessage();
    }
}