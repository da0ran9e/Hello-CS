using System;

class HelloWorld
{
    static void SumOf2Numbers()
    {
        Console.WriteLine("Enter the first number!");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number!");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum is: " + (num1 + num2));
    }
    static long CalculateFactorial(int n)
    {
        if (n == 0) return 1;
        return n * CalculateFactorial(n - 1);
    }
    static void Factorial()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        long fact = CalculateFactorial(number);
        Console.WriteLine("The factorial of " + number + " is: " + fact);
    }
    static void CheckEvenOrOdd()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if(number%2 == 0)
        {
            Console.WriteLine("The number is even!");
        }
        else
        {
            Console.WriteLine("The number is odd!");
        }
    }
    static void ArraySum()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter the elements: ");
        int sum = 0;
        for(int i=0; i<n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        Console.WriteLine("The sum of the array is: " + sum);
    }
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        //SumOf2Numbers();
        //CheckEvenOrOdd();
        //Factorial();
        //ArraySum();
    }
}
