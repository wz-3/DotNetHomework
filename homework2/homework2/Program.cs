using System;
using System.Collections.Generic;
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factors example1 = new Factors();
            example1.Test1();
            Console.WriteLine("\n");
            ArrayCalculate example2 = new ArrayCalculate();
            example2.Test2();
            Console.WriteLine("\n");
            PrimeNum example3 = new PrimeNum();
            example3.Test3();
            Console.WriteLine("\n");
            Test4();
        }
        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1]) return false;
                }
            }
            return true;
        }
        public static void Test4()
        {
            int[,] matrix = {  { 1, 2, 3, 4 },
                         { 5, 1, 2, 3 },
                         { 9, 5, 1, 2 } };
            Console.WriteLine($"result:{IsToeplitzMatrix(matrix)}");
        }
    }

    public class Factors
    {
        public static List<int> Factorize(int num)
        {
            if (num <= 1) throw new ArgumentException("num必须大于1");

            List<int> factors = new List<int>();
            //两个迭代变量：factor是因子，num是迭代除得到的商
            for (int factor = 2; factor * factor <= num; factor++)
            {
                while (num % factor == 0)
                { //重复除以factor
                    factors.Add(factor);
                    num = num / factor;
                }
            }
            if (num != 1) factors.Add(num);//添加剩余的商为素因子
            return factors;
        }
        public void Test1()
        {
            try
            {
                Console.Write("请输入一个整数:");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factorize(num);
                Console.Write("素因子有:");
                factors.ForEach(f => Console.Write("\t" + f));
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误:{e.Message}");
            }
        }


    }
    public class ArrayCalculate
    {
        
        private static void Calculate(int[] nums,out int min, out int max, out int sum, out double average)
        {
            if (nums.Length == 0)
            {
                throw new ArgumentException("数组为空,所有值为0");
            }
           
            max = nums[0];
            min = nums[0];
            sum = 0;
            foreach (int n in nums)
            {
                if (n > max) max = n;
                if (n < min) min = n;
                sum = sum + n;
            }
            average = sum / nums.Length;

            
        }

        public void Test2()
        {
            int[] nums = { 0, 1 ,2, 3, 4, 5, 6, 7, 8 , 9 ,10 };
            
            try
            {
                Calculate(nums, out int min, out int max, out int sum, out double average);
                Console.WriteLine($"min={min},max={max},sum={sum},average={average}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
    
    class PrimeNum
    {
        private static void Filter(bool[] primes)
        {
            if (primes == null || primes.Length == 0) return;
            for (int num = 2; num * num < primes.Length; num++)
            {
                if (!primes[num]) continue; //非素数的倍数不用再次过滤
                                            //筛掉num的num倍、num+1倍、num+2倍...
                for (int nonprime = num * num; nonprime < primes.Length; nonprime += num)
                {
                    primes[nonprime] = false;
                }
            }
        }

        public void Test3()
        {
            const int N = 100;
            bool[] primes = new bool[N + 1];
            for (int i = 2; i < N + 1; i++)
            {
                primes[i] = true;
            }
            Filter(primes);
            Console.WriteLine("从2至100的素数有："+"\n");
            for (int num = 2; num < N + 1; num++)
            {
                if (primes[num])
                {
                    Console.Write($"\t{num}");
                }
            }
        }

    }
    
}
