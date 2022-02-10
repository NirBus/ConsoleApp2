using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Hello Alik You are Hacker");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int[] arr = { };
            if (num <= 50)
            {
                for (int i = 4; i <= num; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                }
            }
            else if (num > 50 && num <= 100)
            {
                for (int i = 6; i < num; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = 9; i <= num; i++)
                {
                    if (i % 8 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            #endregion

            #region Task 2
            //string[] letters = { "lutfiyar", "Allahshukur", "Oruc" };
            //{
            //    for (int i = 0; i < letters.Length; i++)
            //    {
            //        if (letters[i].Length > 5)
            //        {
            //            Console.WriteLine(letters[i]);
            //        }
            //    }
            #endregion

            #region Task 3
            //int num = 125;
            //int remain = 0;
            //while (num != 0)
            //{
            //    remain += num%10;
            //    num = num/10;
            //}
            //Console.WriteLine(remain);
            //{

            //}
            #endregion
        }
    }
}
 

