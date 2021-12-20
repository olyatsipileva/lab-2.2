using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2._2
{
    public static class Logic
    {
        public static String Subsequence(string str)
        {
            string[] nums = str.Split(' ');
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != "")
                {
                    k++;
                }
            }
            int[] array = new int[k];
            k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != "")
                {
                    array[k] = Convert.ToInt32(nums[i]);
                    k++;
                }
            }

            bool mean = true;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            { 
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        count++;
                        if (count == array.Length)
                        {
                            return "Ошибка! Числа не должны быть одинаковыми!";
                        }
                    }
                    if (array[i] > array[j])
                    {
                        mean = false;
                    }
                }
            }
            if (mean)
            {
                return "Последовательность чисел является упорядоченной по возрастанию!";
            }
            else
            {
                return "Последовательность чисел не является упорядоченной по возрастанию!";
            }
        }

    }
}
