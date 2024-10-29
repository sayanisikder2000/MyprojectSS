using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    class ArrayElementCount
    {
        public static void Array2()
        {
            int[] arr = new int[5] { 0, 0, 0, 0, 0 };
            Array.Sort(arr);
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1) < arr.Length)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{arr[i]} comes {count} times");
                        count = 1;
                    }
                }
                else
                {
                    Console.WriteLine($"{arr[i]} comes {count} times");
                }
            }
        }
    }
}
