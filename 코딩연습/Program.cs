using System;

namespace 코딩연습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
        /// <summary>
        /// 평균구하기
        /// </summary>
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
    /// <summary>
    /// 홀짝구분하기
    /// </summary>
    public class Solution
    {
        public string solution(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }

    // 자릿수 더하기
    public class Solution
    {
        public int solution(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10; // 마지막 자릿수 추출
                n /= 10; // 마지막 자릿수 제거
            }


            return sum;
        }
    }


    //약수의 합
    public class Solution
    {
        public int solution(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }


            return sum;
        }
    }


    // 나머지가 1이 되는 수
    public class Solution
    {
        public int solution(int n)
        {
            for (int x = 2; x < n; x++)
            {
                if (n % x == 1)
                {
                    return x;
                }
            }
            return -1;  // 이 부분은 실행되지 않지만, 혹시나를 대비해서 넣습니다.
        }
    }

    //x만큼 간격이 있는 n개의 숫자
    public class Solution
    {
        public int solution(int n)
        {
            for (int x = 2; x < n; x++)
            {
                if (n % x == 1)
                {
                    return x;
                }
            }
            return -1;  // 이 부분은 실행되지 않지만, 혹시나를 대비해서 넣습니다.
        }

    }