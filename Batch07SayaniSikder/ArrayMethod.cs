using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    internal class ArrayMethod
    {
        public static void ArrayMethod1()
        {
            int[] arrA = new int[6] { 50, 10, 40, 60, 20, 20 };
            int[] arrB = new int[12] { 15, 25, 35, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine("Elements of arrA are: ");
            foreach (int i in arrA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Elements of arrB are: ");
            foreach (int i in arrB)
            {
                Console.Write(i + " ");
            }


            Array.Copy(arrA, 0, arrB, 3, 6);
            Console.WriteLine("\nElement of arrB after copying");
            foreach (int i in arrB)
            {
                Console.Write(i + " ");
            }


            Array.Reverse(arrA);
            Console.WriteLine("\nElement of arrA after copying");
            foreach (int i in arrA)
            {
                Console.Write(i + " ");
            }


            Array.Sort(arrA);
            Console.WriteLine("\nElement of arrA after SORTing");
            foreach (int i in arrA)
            {
                Console.Write(i + " ");
            }


            Console.Write("\n Enter the search elements: ");
            int s = int.Parse(Console.ReadLine());
            int F = Array.BinarySearch(arrA, s);
            if (F >= 0)
            {
                Console.WriteLine($"Search element found in {0} location",(F+1));
            } else
            {
                Console.WriteLine($"Search element not found: ");
            }
            Array.Clear(arrA,2,3);
            Console.WriteLine("Element of arrA after clearing");
            foreach(int i in arrA)
            {
                Console.Write(i + " ");
            }

        }
    }
}
