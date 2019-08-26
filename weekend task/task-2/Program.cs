
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aralarında boşluq simvolu olmaqla ədədlər daxil edin: ");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            string[] a = Program.ReverseMyArray(inputArray);



            int maxIndex = Program.FindMax(inputArray);
            if (maxIndex > -1)
            {
                Console.WriteLine($"Max element: {inputArray[maxIndex]} | index: {maxIndex}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadLine();
        }


        public static int FindMax(string[] arr)
        {
            int index = -1; 

            if (arr.Length > 0)
            {
                index = 0;
                int max;
                bool isParsed = int.TryParse(arr[0], out max);
                if (!isParsed)
                {
                    return -1;
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    int currentElement = Convert.ToInt32(arr[i]);

                    if (max < currentElement)
                    {
                        max = currentElement;
                        index = i;
                    }
                }
            }
            return index;
        }

        public static string[] ReverseMyArray(string[] arr)
        {
            string[] newArray = new string[arr.Length];
            int j = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[j];

                j--;
            }



            return newArray;
        }

    }
}