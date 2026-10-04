Console.WriteLine("Welcome to our calculator");
Console.Write("Enter first number: ");

if (!int.TryParse(Console.ReadLine(), out int x))
{
    Console.WriteLine("Invalid first number.");
    return;
}

Console.Write("Enter second number: ");

if (!int.TryParse(Console.ReadLine(), out int y))
{
    Console.WriteLine("Invalid second number.");
    return;
}
Calculator c1 = new Calculator();
int result = c1.Add(x, y);
Console.WriteLine($"the result is {result}");