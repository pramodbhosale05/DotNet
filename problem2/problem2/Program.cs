using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int max = 0;
            string str = "We test coders.Give us a try asd asd?";
            int arraySize = 0;
            int tempSize = 0;
            string finalString = string.Empty;
            // string[] tokens = System.Text.RegularExpressions.Regex.Split(str, @"\?+\!+\.");


            string[] separators = { "?", "!", "." };
            // string value = "The handsome, energetic, young dog was playing with his smaller, more lethargic litter mate.";
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string subtring in words)
            {
                tempSize = subtring.Trim().Split(' ').Length;
                if (tempSize > arraySize)
                {
                    arraySize = tempSize;
                }
            }
            Console.WriteLine(arraySize);

            Console.ReadLine();
        }
    }
}

 
