namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int faktarial = int.Parse(Console.ReadLine());
            int sumf = sumfaktarial(faktarial);
            Console.WriteLine($"The factorial of {faktarial} is {sumf}");
        }

        static int sumfaktarial(int sum)
        {
            int rersult = 1;
            for (int i = 1; i <= sum; i++)
            {
                rersult *= i; // Multiply the current result by i
            }
            return rersult;
        }

    }
}
