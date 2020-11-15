using System;

namespace Task1
{
    class Program
    {
        public static bool luckySix(int [] arrayOfIntegers)
        {
            int sum = 0;
            for(int index = 0; index < arrayOfIntegers.Length - 2; index++)
            {
                sum = arrayOfIntegers[index] + arrayOfIntegers[index+1] + arrayOfIntegers[index+2];
                //Console.WriteLine(sum);
                if(sum == 6)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] testArray1 = {1,0,3,4,5,6};
            int[] testArray2 = {1,5,10,3,2,0,2,2,2,5};
            int[] testArray3 = {1,1,1,3,7,0,2,3,2,5,0,0,6};

            Console.WriteLine(luckySix(testArray1));
            Console.WriteLine();
            Console.WriteLine(luckySix(testArray2));
            Console.WriteLine();
            Console.WriteLine(luckySix(testArray3));
        }
    }
}
