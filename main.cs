using System;

namespace Manila_2081
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASCII INTRO ART
            string line = "";

            // Intro
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"source/text/intro/welcome.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

						// Basic Lore
						
            file =
                new System.IO.StreamReader(@"source/text/intro/lore_basic.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
        }
    }
}
