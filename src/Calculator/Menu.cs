namespace Calculator;

public static class Menu
{
    public static void Show()
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("========== \n");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("0. Exit");
        Console.WriteLine();
    }
}