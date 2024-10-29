using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    class AgeOfaPerson
    {
        public static void Age1()
        {
            int age;
            Console.WriteLine("Enter your age: ");

            age = int.Parse(Console.ReadLine());    

            Console.WriteLine("You are " + age + " years old.");
        }

    }
}
