using System;
using System.Collections.Generic;

namespace binarysearch
{
    class linear
    {
        static int m1(int[]number, int target)
        {
            for(int i=0;i<=number.Length;i++)
            {
                if(number[i] == target)
                {
                    return i;
                }
                
            }
            return -1;
        }
        public static int BinarySearch(int[] numbers, int key)
        {
            int min=0;
            int max=numbers.Length - 1;

            while(min<=max)
            {
                int mid = (min + max) / 2;

                if(key == numbers[mid])
                {
                    return ++mid;
                }
                else if (key < numbers[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
            {
                System.Console.WriteLine("linear search : ");
                int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                int index = m1(number, 5);
                Console.WriteLine("The number 5 is at  " + index);

                System.Console.WriteLine("binary search : ");
                int indexx = m1(number,7);
                System.Console.WriteLine(indexx);

            }
    }
}