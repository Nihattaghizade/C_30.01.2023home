using System;

namespace _30._01._2023hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmiş qiymət dəyəri 64-dən böyük olarasa ... proqram

            int N;
            Console.WriteLine("Ededi daxil et:");
            N = int.Parse(Console.ReadLine());

            while (N < 0 || N > 100)
            {
                Console.WriteLine("Ededi daxil et:");
                N = int.Parse(Console.ReadLine());
            }

            if (N >= 64 && N <= 100)
            {
                Console.WriteLine("Mezun oldun");
            }
            else
            {
                Console.WriteLine("Mezun olmadin");
            }




            //Verilmiş ədədin rəqəmləri cəmini tapan proqram

            Console.WriteLine("Ededi daxil et");
            string input1 = Console.ReadLine();
            int N = Convert.ToInt32(input1);

            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N = (N - N % 10) / 10;
            }
            Console.WriteLine(sum);




            //Verilmiş ədədlər siyahısındaki 21-ə bölenən ədədlərin ədədi ortasını tapan proqram

            int[] nums = new int[] { 2, 13, 21, 35, 42, 55, 63 };
            int count = 0;
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 21 == 0)
                {
                    sum += nums[i];
                    count++;
                }
            }
            avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
