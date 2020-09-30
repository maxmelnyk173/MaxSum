using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MaxSum
{
    public class NumberOfRow
    {
        string FilePath { get; }

        public string[] StrArray { get; set; }

        public NumberOfRow() 
        { 
        }

        public NumberOfRow(string filePath)
        {
            FilePath = filePath;

            StrArray = File.ReadAllLines(filePath);
        }

        public int MaxArrayNumber()
        {
            int[] arrayOfSums = new int[StrArray.Length];

            for (int i = 0; i < StrArray.Length; i++)
            {
                int sumOfNumbers = Regex.Matches(StrArray[i], @"\d+")
                                        .Cast<Match>()
                                        .Select(x => int.Parse(x.Value))
                                        .Sum();

                arrayOfSums[i] = sumOfNumbers;
            }

            var indexOfArray = Array.IndexOf(arrayOfSums, arrayOfSums.Max());

            return indexOfArray+1;
        }

        public List<int> ArraysWithLetters()
        {
            List<int> arrayOfSums = new List<int>();

            for (int i = 0; i < StrArray.Length; i++)
            {
                var arrWithLetters = Regex.IsMatch(StrArray[i], @"[a-zA-Z]");
                if (arrWithLetters == true) { arrayOfSums.Add(i); }
            }

            return arrayOfSums;
        }
    }
}
