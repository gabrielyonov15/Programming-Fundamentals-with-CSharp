﻿namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CheckNumber(n);
        }
        static void CheckNumber(int number)
        {
            if(number >0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
                if(number <0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
