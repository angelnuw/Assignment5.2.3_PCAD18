namespace Assignment5._2._3
{
    internal class Program
    {
        static void Number_TailRecursion(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n + " ");
                Number_TailRecursion(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Number_TailRecursion(10);
            Console.ReadKey();
        }
    }
}
