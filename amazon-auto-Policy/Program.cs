using System;

namespace amazon_auto_Policy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 25, 23, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 76, 80 };

            Console.WriteLine(autoPolicy(arr,2));
        }

        static decimal autoPolicy(int[] arr, decimal instance)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 25)
                {
                    if (instance > 1)
                    {
                        decimal d = instance / 2;
                        instance = (int)Math.Ceiling(d);
                    }
                        
                    i += 10;
                }
                if(arr[i] > 60)
                {
                    if ((instance * 2) < 217)
                        instance = instance * 2;
                    i += 10;
                }
            }
            return instance;
        }
    }
}
