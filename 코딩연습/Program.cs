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


    ///자연수 뒤집어 배열로 만들기
    using System;
using System.Collections.Generic;

public class Solution
    {
        public int[] solution(long n)
        {
            List<int> answer = new List<int>();

            while (n > 0)
            {
                answer.Add((int)(n % 10));
                n /= 10;
            }

            return answer.ToArray();
        }
    }

    //문자열을 정수로 바꾸기
    public class Solution
    {
        public int solution(string s)
        {
            return int.Parse(s);
        }
    }





    // 정수 제곱근 판별
    using System;

public class Solution
    {
        public long solution(long n)
        {
            // 제곱근을 구한다.
            double sqrtN = Math.Sqrt(n);

            // 제곱근이 정수라면
            if (sqrtN == (long)sqrtN)
            {
                long nextInt = (long)sqrtN + 1;
                return nextInt * nextInt;
            }

            return -1;
        }

    }




    //정수 내림차순으로 배치하기
    using System;
using System.Linq;

public class Solution
    {
        public long solution(long n)
        {
            // 숫자를 문자열로 변환 후, 내림차순 정렬
            string sortedStr = new string(n.ToString().OrderByDescending(c => c).ToArray());

            // 문자열을 다시 숫자로 변환
            return long.Parse(sortedStr);
        }
    }


    2023-09-01
    //하샤드의 수
    public class Solution
    {
        public bool solution(int x)
        {
            int sum = 0;
            int temp = x;

            while (temp > 0)
            {
                sum += temp % 10; // 현재 숫자의 마지막 자리를 합산
                temp /= 10;      // 숫자를 10으로 나누어 다음 자릿수로 이동
            }

            return x % sum == 0; // x가 자릿수의 합으로 나누어 떨어지면 true 반환
        }
    }

    //두 정수 사이의 합
    public class Solution
    {
        public long solution(int a, int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            long sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }
    }

    //콜라츠 추측
    using System;

public class Solution
    {
        public int solution(int num)
        {
            long number = num;// Convert int to long
            int i; //500번의 반복 동안 숫자가 1에 도달하지 않으면 -1을 반환해야 한다. 현재 로직에서는 1에 도달하면 그때의 횟수를 반환하게 되어 있어서 수정
            for (i = 0; i < 500; i++)
            {
                if (number == 1) break;
                number = (number % 2 == 0) ? number / 2 : number * 3 + 1;
            }
            return (number == 1) ? i : -1;
        }
    }

    //서울에서 김서방 찾기
    using System;

public class Solution
    {
        public string solution(string[] seoul)
        {
            int position = Array.IndexOf(seoul, "Kim");
            return $"김서방은 {position}에 있다";
        }

    }

    //나누어 떨어지는 숫자 배열
    using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> answer = new List<int>();

            foreach (var num in arr)
            {
                if (num % divisor == 0)
                {
                    answer.Add(num);
                }
            }

            if (answer.Count == 0)
            {
                return new int[] { -1 };
            }

            return answer.OrderBy(x => x).ToArray();
        }
    }
    
    //음양 더하기
    using System;

public class Solution
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int sum = 0;

            for (int i = 0; i < absolutes.Length; i++)
            {
                if (signs[i])
                {
                    sum += absolutes[i];
                }
                else
                {
                    sum -= absolutes[i];
                }
            }

            return sum;
        }
    }