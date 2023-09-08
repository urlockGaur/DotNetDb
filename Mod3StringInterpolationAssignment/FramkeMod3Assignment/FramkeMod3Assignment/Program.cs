using System;

namespace FramkeStringInterpolationAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my String Interpolation Assignment");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Answers: ");
            Console.WriteLine();
            // USE THE CURRENT DAY FOR THE ASSIGNMENT
            //Display the following using string interpolation:

            //From today’s date ----- 9/8/2023

            // 1.   January 22, 2019(right aligned in a 40 character field)

            var date = DateTime.Now; 
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");

            //2.    2019.01.22

            Console.WriteLine($"{date:yyyy.MM.dd}");

            // 3.   Day 22 of January, 2019

            Console.WriteLine($"Day {date:dd} of {date:Y}");

            //4.    Year: 2019, Month: 01, Day: 22

            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");

            //5.    Tuesday (10 spaces total, right aligned)

            Console.WriteLine($"{date,10:dddd}");

            //6.     11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)

            Console.WriteLine($"{date,10:t}{date,10:dddd}");

            //7.    h:11, m:01, s:27

            Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");

            //8.    2019.01.22.11.01.27

            Console.WriteLine($"{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}");


            //If you have PI (3.1415) - use var pi = Math.PI;

            //1.    Output as currency

            var pi = Math.PI;
            Console.WriteLine($"{pi:C}"); // C is used for currency source: https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting

            //2.    Output as right-aligned (10 spaces), number with 3 decimal places

            Console.WriteLine($"{pi,10:N3}"); // N is used for numeric formatting with decimal places - https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
























        }
    }
}