using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class CubeSumOfElements
    {
        public static void CubeSum() 
        {
            int sum = 0;
            int[] arr = new int[6];
            Console.WriteLine("Enter 6 integer values: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("Array Elements are :"+" ");
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + (arr[i] * arr[i] * arr[i]);
            }
            Console.WriteLine("Total = "+ sum);
        }
    }
}
