using Calculator;

Menu.Show();

short choice = short.Parse(Console.ReadLine());

while (choice != 0)
{    
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine($"{a} + {b} = {Operations.Add(a, b)}");
            break;
        case 2:
            Console.WriteLine($"{a} - {b} = {Operations.Subtract(a, b)}");
            break;
        case 3:
            Console.WriteLine($"{a} * {b} = {Operations.Multiply(a, b)}");
            break;
        case 4:
            Console.WriteLine($"{a} / {b} = {Operations.Divide(a, b)}");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();    
    Menu.Show();
    choice = short.Parse(Console.ReadLine());
}