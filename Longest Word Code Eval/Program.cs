using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Word_Code_Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string line = "Some line of text";
             string[] lineWords = line.Split();
             //need a for loop to find the longest word
             //tell the computer to find the longest word in the array or line
             int LongestWordSoFarIndex = -0;
             int LongestWordSoFarLength = 0;
             for (int counter = 0; counter < lineWords.Length; counter++)
             {
                if(lineWords[counter].Length > LongestWordSoFarLength)
                 {
                     LongestWordSoFarLength = lineWords[counter].Length;
                     LongestWordSoFarIndex = counter;
                 } 

             }
             Console.WriteLine(lineWords[LongestWordSoFarIndex]);*/

            string line = "Some ' ' line ' ' of ' ' text";
            string [] words = line.Split();//initializing a new string array and spliting the array
            string longest = ""; //another string called longest, and no value
            foreach(string word in words)//create a foreach loop and declare a new string called word
            {
                if (word.Length > longest.Length)//begin an if statement, comparing length of string word to length of string
                    longest = word;
            }
            Console.Write(longest);//prints out word with most characters
            Console.WriteLine();
        }
    }
}
