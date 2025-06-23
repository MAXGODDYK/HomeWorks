namespace ConsoleApp1
{
    internal class Program
    {

        static void FillArratWithRandomNumbers(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 99); // Fill with random numbers between 1 and 100
            }
        }

        static void PrinttArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void ReversArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int t = array[i]; // Temporary variable to hold the value
                array[i] = array[array.Length - 1 - i]; // Swap the elements
                array[array.Length - 1 - i] = t; // Assign the temporary value to the other end
            }
        }
        static void Main(string[] args)
        {
            const int N = 10; // Example constant
            int[] inputArray = new int[N]; // Declare an array of size N

            FillArratWithRandomNumbers(inputArray);
            PrinttArray(inputArray);
            ReversArray(inputArray);
            PrinttArray(inputArray);


            
        }
        




        

    }
}
