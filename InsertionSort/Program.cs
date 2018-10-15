using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayData = { 10, 5, 15, 3, 8, 45, 9 };
            Console.WriteLine("Array Data ");
            foreach (int i in arrayData)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Sorted array data");

            for (int j = 1; j <= arrayData.Length - 1; j++)
            {
                var key = arrayData[j];
                // inster arrayData[j] into the sorted squence arrayData[1,2...j-1]
                int i = j - 1;
                while (i >= 0 && arrayData[i] > key)
                {
                    arrayData[i + 1] = arrayData[i];
                    i = i - 1;
                    arrayData[i + 1] = key;
                }
            }

            foreach (int i in arrayData)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
