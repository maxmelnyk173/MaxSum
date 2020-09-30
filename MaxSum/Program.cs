using System;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path");
            string filePath = Console.ReadLine();

            var StrArray = new NumberOfRow(filePath);

            Console.WriteLine("Line number with the maximum sum of elements: " + StrArray.MaxArrayNumber());

            Console.WriteLine("Line numbers with numeric and non-numeric elements type:");
            var listWithLetters = StrArray.ArraysWithLetters();  
            foreach (var item in listWithLetters)
            {
                Console.WriteLine(item+1);
            }
        }
    }
}
