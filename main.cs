using System;

namespace Manila_2081
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASCII INTRO ART
            string line = "";

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"text/intro_welcome.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

            //Line Break Before Ending
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
