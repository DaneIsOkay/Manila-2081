using System;

class MainClass {
  public static void Main (string[] args)
        {
            //ASCII INTRO ART

            System.IO.StreamReader title =
                new System.IO.StreamReader(@"https://replit.com/@DaneAnselAnsel/Manila-2081#text/intro_welcome");
            while ((title = file.ReadLine()) != null)
            {
                System.Console.WriteLine(title);
            }
        }
}