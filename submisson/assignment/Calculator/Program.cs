Console.WriteLine("Welcome to our calculator");

bool continueCalculations = true;

while (continueCalculations)
{
    Console.WriteLine("Select an operation:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.Write("Enter your choice (1-4): ");

    if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 4)
    {
        Console.WriteLine("Invalid operation choice. Please enter a number between 1 and 4.");
        continue;
    }

    Console.Write("Enter first number: ");
    if (!int.TryParse(Console.ReadLine(), out int x))
    {
        Console.WriteLine("Invalid first number.");
        continue;
    }

    Console.Write("Enter second number: ");
    if (!int.TryParse(Console.ReadLine(), out int y))
    {
        Console.WriteLine("Invalid second number.");
        continue;
    }

    Calculator calculator = new Calculator();
    switch (operation)
    {
        case 1:
            calculator.Add(x, y);
            break;

        case 2:
            calculator.Subtract(x, y);
            break;

        case 3:
            calculator.Multiply(x, y);
            break;

        case 4:
            calculator.Divide(x, y);
            break;
    }

    Console.Write("\nDo you want to perform another operation? (yes/no): ");
    string nextOperation = Console.ReadLine()?.ToLower() ?? "no";

    if (nextOperation != "yes" && nextOperation != "y")
    {
        continueCalculations = false;
        Console.WriteLine("Thank you for using the calculator!");
    }
}

Console.ReadLine();