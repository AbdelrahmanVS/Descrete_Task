internal class Program
{
    private static void Main(string[] args)
    {
        //call the function
        //prime_numbers();
        //prime_numbers_another_way();

    }
    static void prime_numbers()
    {
        Console.WriteLine("  Enter number to start the array");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("  Enter number to end the array");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("  Prime numbers from {0} to {1} is :", num1, num2);
        for (int i = num1; i <= num2; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    sum++;
            }
            if (sum == 2)
                Console.WriteLine( " "+ i);
        }
    }
    static void prime_numbers_another_way()
    {
        Console.WriteLine("Enter number to start the array");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to end the array");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("  Prime numbers from {0} to {1} is :", num1, num2);
        for (int i = num1; i < num2; i++)
        {
            if (i == 1)
                continue;
            if (i % 2 == 0 && i != 2)
                continue;
            else if (i % 3 == 0 && i != 3)
                continue;
            else if (i % 5 == 0 && i != 5)
                continue;
            else if (i % 7 == 0 && i != 7)
                continue;
            else
                Console.WriteLine(i);

        }
    }


}
