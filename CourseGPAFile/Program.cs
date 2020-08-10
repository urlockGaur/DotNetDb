using System;

namespace CourseGPAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // TODO: read data from file
                }
                else if (choice == "2")
                {
                    // TODO: create file from data
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
