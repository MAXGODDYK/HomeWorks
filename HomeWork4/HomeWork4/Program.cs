int[] mynum = new int[10];
Console.WriteLine("Enter 10 numbers:");


for (int i = 0; i < mynum.Length; i++)
{
    Console.Write($"Number {i + 1}: ");
    mynum[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("Enter the number we are looking for:");
int yuernum = int.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < mynum.Length; i++)
{
    if (mynum[i] == yuernum)
    {
        Console.WriteLine($"Number in place {i+=1}");
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Number not found");
}
else
{
    Console.WriteLine($"Number found {count} times");
}
for (int i = 0; i < mynum.Length; i++)
{
    Console.WriteLine(mynum[mynum.Length - 1 - i]);
}



