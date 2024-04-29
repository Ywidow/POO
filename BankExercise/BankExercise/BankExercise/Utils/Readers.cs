namespace BankExercise.Utils;

public static class Readers{
    public static int ReadIntValue() => int.Parse(Console.ReadLine()!);
    

    public static int ReadMenuChoose(){
        try
        {
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        catch (Exception)
        {
            return -1;
        }
    }

    public static double ReadDoubleValue() => double.Parse(Console.ReadLine()!);
}