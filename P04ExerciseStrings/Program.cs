using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ExerciseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Part 1 -------");
            Console.WriteLine("Please enter two numbers one by one");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            string sumAsString = Convert.ToString(sum);

            int digitCount = Convert.ToInt32(sumAsString.Length);


            string report1 = "The result " + sum + " consists of: " + digitCount + " digits";

            string report2 = $"the result {sum} consits of: {digitCount} digits";

            string report3 = string.Format("The result {0} consists of {1} digits",sum,digitCount);

            Console.WriteLine(report3);
            // Console.WriteLine(sumAsString);
            //
            //https://github.com/tomasz-trener/21Day1

        }
    }
}
