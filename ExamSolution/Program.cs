using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool SharedDigit(int[] arr)
        {
            int count = 0;
            int num = arr[0];

            while (num > 0)
            {

                int digit = num % 10;
                int correct_times = arr.Length - 1;
                int times = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    bool isIn = DigitAppears(digit, arr[i]);
                    if (isIn)
                    {
                        times++;
                    }
                }
                if (times == correct_times)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;

        }

        private static bool DigitAppears(int digit, int n)
        {
            while (n > 0)
            {
                if (digit == n % 10)
                    return true;
                n /= 10;
            }
            return false;
        }

        public static String q2(int n)
        {
            string phrase = "";
            //
            int partNum = 80;
            phrase = partNum +phrase;

        }
    }
}
