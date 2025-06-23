namespace HomeWork6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int number = 2;

            while (true)
            {
                if (IsPrime(number))
                {
                    count++;
                    if (count == inputNumber)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                }
                number++;
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
