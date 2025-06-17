// See https://aka.ms/new-console-template for more information
int var = 12345;

int v1 = var / 10000; 
int v2 = (var / 1000) % 10; 
int v3 = (var / 100) % 10; 
int v4 = (var / 10) % 10; 
int v5 = var % 10; 

Console.WriteLine(var); 

Console.WriteLine(v1);
Console.WriteLine(v2);
Console.WriteLine(v3);
Console.WriteLine(v4);
Console.WriteLine(v5);


Console.WriteLine("Ведите массив: ");
int[] faifthMas = new int[5];
for (int i = 0; i < 5; i++) 
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    string strfaifthMas = Console.ReadLine();
    if (int.TryParse(strfaifthMas, out int val))
    {
        faifthMas[i] = val;
    }
    else
    {
        Console.WriteLine("Ошибка ввода, введите число.");
        i--; // Повторяем итерацию для текущего индекса
    }
}
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(faifthMas[i]);
}

int numbersMin = 0;
int numbersMax = 0;
for (int i = 1; i < 5; i++)
{
    numbersMin = faifthMas[0];
    if (numbersMin > faifthMas[i])
    {
        numbersMin = faifthMas[i];
    }
}
Console.WriteLine("Min: " + numbersMin);
for (int i = 1; i < 5; i++)
{
    numbersMax = faifthMas[0];
    if (numbersMax < faifthMas[i])
    {
        numbersMax = faifthMas[i];
    }
}
Console.WriteLine("Max: " + numbersMax);

 