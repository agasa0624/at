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

    //핸드폰 번호 가리기
    using System;

public class Solution
    {


        public string solution(string phone_number)
        {
            int len = phone_number.Length;

            // 전화번호의 뒷 4자리를 제외한 나머지를 '*'로 변환
            string hiddenPart = new String('*', len - 4);

            // 숨겨진 부분과 원래 전화번호의 뒷 4자리를 합쳐서 반환
            return hiddenPart + phone_number.Substring(len - 4);
        }

    }
    //없는 숫자 더하기
    using System;
using System.Linq;

public class Solution
    {
        public int solution(int[] numbers)
        {
            // 0부터 9까지의 합은 45이므로
            int total = 45;

            // numbers에 포함된 숫자들을 전체 합에서 빼면
            // numbers에 없는 숫자들의 합을 얻을 수 있습니다.
            return total - numbers.Sum();
        }
    }

    //제일 작은 수 제거하기
    using System;
using System.Linq;

public class Solution
    {
        public int[] solution(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return new int[] { -1 };
            }

            int minValue = arr.Min(); // 배열에서 가장 작은 값을 찾습니다.
            return arr.Where(n => n != minValue).ToArray(); // 가장 작은 값을 제외한 배열을 반환합니다.
        }
    }

    // 가운데 글자 가져오기

    public class Solution
    {
        public string solution(string s)
        {
            int length = s.Length;
            if (length % 2 == 0)
            {
                // 짝수인 경우 중간의 두 글자 반환
                return s.Substring(length / 2 - 1, 2);
            }
            else
            {
                // 홀수인 경우 중간의 한 글자 반환
                return s.Substring(length / 2, 1);
            }
        }
    }

//약수의 개수와 덧셈
using System;

public class Solution
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                if (IsEvenDivisorCount(i))
                {
                    answer += i;
                }
                else
                {
                    answer -= i;
                }
            }
            return answer;
        }

        // 약수의 개수가 짝수인지 홀수인지 판별하는 함수
        private bool IsEvenDivisorCount(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count % 2 == 0;
        }
    }

    //문자열 내림차순으로 배치하기
    using System;
using System.Linq;

public class Solution
    {
        public string solution(string s)
        {
            return new string(s.OrderByDescending(c => c).ToArray());
        }
    }

    //부족한 금액 계산하기
    public class Solution
    {
        public long solution(int price, int money, int count)
        {
            long totalCost = (long)price * count * (count + 1) / 2;
            long lack = totalCost - money;

            return lack > 0 ? lack : 0;
        }
    }


    //문자열 다루기 기본
   using System;
using System.Linq;

public class Solution
    {
        public bool solution(string s)
        {
            if (s.Length == 4 || s.Length == 6)
            {
                return s.All(char.IsDigit);
            }
            return false;
        }
    }

    
    //행렬의 덧셈

    using System;

public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int rows = arr1.GetLength(0);
            int cols = arr1.GetLength(1);

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return result;
        }
    }

    //직사각형 별찍기

    using System;

public class Program
    {
        public static void Main()
        {
            int n = GetValidNumber("Enter n:");
            int m = GetValidNumber("Enter m:");

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }

        static int GetValidNumber(string prompt)
        {
            int number;
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine(prompt);
            }
            return number;
        }
    }

    //최대공약수와 최소공배수
    public class Solution
    {
        public int[] solution(int n, int m)
        {
            int gcd = GCD(n, m);
            int lcm = n * m / gcd;

            return new int[] { gcd, lcm };
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
    }

    //3진법 뒤집기
    public class Solution
    {
        public int solution(int n)
        {
            string reversedTernary = "";

            // n을 3진법으로 변환하면서 그 값을 반대로 뒤집는다.
            while (n > 0)
            {
                reversedTernary += n % 3;
                n /= 3;
            }

            // 뒤집힌 3진법 값을 다시 10진법으로 변환한다.
            int result = 0;
            int multiplier = 1;
            for (int i = reversedTernary.Length - 1; i >= 0; i--)
            {
                result += (reversedTernary[i] - '0') * multiplier;
                multiplier *= 3;
            }

            return result;
        }
    }

    //이상한 문자 만들기
    public class Solution
    {
        public string solution(string s)
        {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        chars[j] = char.ToUpper(chars[j]);
                    }
                    else
                    {
                        chars[j] = char.ToLower(chars[j]);
                    }
                }
                words[i] = new string(chars);
            }

            return string.Join(" ", words);
        }
    }

    //소수 만들기
    
public class Solution
    {
        public int solution(int[] nums)
        {
            int answer = 0;

            // 3중 for 문을 사용하여 3개의 숫자 조합을 모두 검사합니다.
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];
                        if (IsPrime(sum))
                        {
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }

        private bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }