namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyArray mr = new MyArray();

            List<int> list = new List<int>();

            while (true)
            {
                int inputVulue = int.Parse(Console.ReadLine());

                if (inputVulue != 0)
                {
                    list.Add(inputVulue);
                }
                else
                {
                    int length = list.Count;
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(list[length - 1 - i] + " ");
                    }
                    //Exit the loop
                    break;
                }
            }
        }
    }
}
