// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> evens = new List<int>();
        List<int> odds = new List<int>();
        List<int> primes = new List<int>();

        foreach (int num in numbers) 
        {
            if (IsEven(num))
                evens.Add(num);

            if (IsOdd(num))
                odds.Add(num);

            if (IsPrime(num))
                primes.Add(num);
        }

        Console.WriteLine("Even Numbers:");
        PrintList(evens);

        Console.WriteLine("Odd Numbers:");
        PrintList(odds);

        Console.WriteLine("Prime Numbers:");
        PrintList(primes);
    }


    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    static bool IsOdd(int n)
    {
        return n % 2 != 0;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void PrintList(List<int> list)
    {
        foreach (int n in list)
            Console.Write(n + " ");

        Console.WriteLine();
    }
}


