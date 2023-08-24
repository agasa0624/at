using System;

namespace 코딩연습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        

    public class Solution
        {
            public double solution(int[] arr)
            {
                double sum = 0;

                if (arr.Length < 1 || arr.Length > 100)
                {
                    throw new ArgumentException("Array length should be between 1 and 100.");
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < -10000 || arr[i] > 10000)
                    {
                        throw new ArgumentException("Array element should be between -10,000 and 10,000.");
                    }
                    sum += arr[i];
                }

                return sum / arr.Length;
            }
        }

    }
}