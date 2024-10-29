using System;

class Program
{
    public static void Main(string[] args)
    {
        // Comment and uncomment these individually, otherwise there is a lot that will be outputted in the terminal:

        Write1ThroughN_While(5);
        // Write1ThroughN_For(5);
        // WriteNThrough1_While(1);
        // WriteNThrough1_For(1);
        // WriteEvensThrough100();
        // FindSum(5);
        // FindSumOfEvenNumbers(8);
        // FindSumOfOddNumbers(7);
        // OutputRightTriangle(5);
        // OutOfRangeMessage(0);
    }

    public static void Write1ThroughN_While(int n)
    {
        int counter = 1;

        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int number = 5;

        while (number >= n)
        {
            Console.WriteLine(number);
            number--;
        }
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        for (int b = 5; b >= n; b--)
        {
            Console.WriteLine(b);
        }
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }

    public static void WriteEvensThrough100()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }

    public static void FindSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int _base)
    {
        for (int i = 1; i <= _base; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine(n + " is out of range where n is the integer parameter.");
    }
}