using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class ArrayRepeatingElement
    {
        public static void ArrayOutput()
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //sorting part
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j]= arr[i];
                        arr[i]= temp;
                    }
                }
            }
            //AfterSortingElements
            foreach(int y in arr)
            {
                Console.Write(y+" ");
            }
            Console.WriteLine();
            //Calculation of Repeating Element
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length && (i + 1) < arr.Length)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        count++;
                    }
                    else //if (count > 1) 
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
