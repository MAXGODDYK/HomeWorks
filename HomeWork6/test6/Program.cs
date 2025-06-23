namespace test6
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n!=1)
            {   
                return n * Factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
