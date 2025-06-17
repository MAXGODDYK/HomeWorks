
/*
while (true)
{
  
}

Console.WriteLine("Enter the first number, an operator (+, -, *, /), and the second number separated by spaces.");
var Strnum1 = Console.ReadLine();
if (int.TryParse(Strnum1, out int num1))
{
    Console.WriteLine($"The num1 is {num1}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

var znak = Console.ReadLine();

var Strnum2 = Console.ReadLine();
if (float.TryParse(Strnum2, out float num2))
{
    Console.WriteLine($"The num2 is {num2}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

if (znak == "+")
{
    Console.WriteLine($"The result is {num1 + num2}");
}
else if (znak == "-")
{
    Console.WriteLine($"The result is {num1 - num2}");
}
else if (znak == "*")
{
    Console.WriteLine($"The result is {num1 * num2}");
}
else if (znak == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine($"The result is {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
}
*/
Console.Write("Введите число: ");
string numberString = Console.ReadLine();

if (int.TryParse(numberString, out int number))
    if (number < 0)
    {
    if (number <= 1)
    {
        Console.WriteLine($"{number} не является простым числом.");
        return;
    }

    int y = 0;

    for (int i = 1; i <= number; i++)
    {
        if (number % i != 0)
        {
            y++;
        }
    }

    // Число простое, если у него ровно два делителя (делится только на 1 и само себя),
    // значит, в цикле будет `number - 2` неделителей.
    if (y == number - 2)
    {
        Console.WriteLine($"{number} — простое число.");
    }
    else
    {
        Console.WriteLine($"{number} — не простое число.");
    }
}
else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите целое число.");
}






