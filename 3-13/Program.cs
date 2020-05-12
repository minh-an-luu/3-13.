using System;

namespace _3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal1 = { 5, 6, 20, 19, 5, 16, 20, 13, 1, 11 };
            int[] tal2 = { 16, 19, 6, 1, 8, 17, 11, 1, 20, 13 };
            Sortering(tal2);
            Sortering(tal1);
            
            
        }
        static void Sortering(int[] tal)
        {
            for (int i = 1; i < tal.Length; i++)
            {
                int temp = tal[i];
                int n = i - 1;
                while (n >= 0 && tal[n] > temp)
                {
                    tal[n + 1] = tal[n];
                    n--;
                }
               tal[n+1]=temp
            }
               
        }
    }
}
