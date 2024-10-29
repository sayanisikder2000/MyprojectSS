using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class changeSizeOfArrAtRunTime
    {
        public static void ArrayMethod2()
        {
            int[] arr = new int[] { 50, 10, 40, 60, 20, 30 };
            Console.WriteLine("Elements of array a are: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nenter the new size of array:-");
            int s = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, s);
            Console.WriteLine("element of new size array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
