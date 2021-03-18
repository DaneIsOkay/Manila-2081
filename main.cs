using System;
using System.IO;

namespace Manila_2081
{
    class Program
    {
        static void Main(string[] args)
        {
        //SECTION: Pre-programming Notes
          //1. When initiating new variables, ensure use of CamelCase.

        //SECTION: Initalization for Variables Used Throughout The Program
            //System.IO.StreamReader is used to pull text from the source folder.
            System.IO.StreamReader TextPuller;
            string PulledText = "";

        //SECTION: Initialization for Variables Used in Introduction 
            //System.IO.DirectoryInfo is used to count the amount of files in a certain folder. In this case, it counts how many files there are in the source/lore/intro tab. This is used later in "SECTION: Primary Select Screen" in order to simplify the code.
            System.IO.DirectoryInfo IntroLoreCounter = new System.IO.DirectoryInfo(@"source/lore/intro");
            int IntroLoreTotal = dir.GetFiles().Length;
            int IntroLoreCount = 0;
            string IntroPairChoice = "";
            
            

        //SECTION: "Welcome!" ASCII Art
            
            //This is an example of the StreamReader doing its work. It pulls text from the path "source/text/intro/welcome.txt" and assigns it to Text Puller. 
            TextPuller = new System.IO.StreamReader(@"source/text/intro/welcome.txt");
            //After that, the line that TextPuller is on is assigned to the string PulledText *UNTIL* the line is null.  
            //Note that null is different from "".
            while ((PulledText = TextPuller.ReadLine()) != null)
            {
                System.Console.WriteLine(PulledText);
            }
					  
        //SECTION: Front Desk Dialogue

						Console.WriteLine("Padayon, champions! Here you are at the Tondo Dome. What does your heart desire?");
						            
        //SECTION: Primary Select screen

            //The primary select screen loops until you select Exit("3").              
            while(IntroPairChoice != "3")
            {
                TextPuller = new System.IO.StreamReader(@"source/text/intro/choices.txt");
                while ((PulledText = TextPuller.ReadLine()) != null)
                {
                System.Console.WriteLine(PulledText);
                }
                Console.WriteLine("");
                IntroPairChoice = Console.ReadLine();
                Console.WriteLine("");

                if(IntroPairChoice == "1")
                {
                    
                    IntroLoreCount++;
                    
                    if(IntroLoreCount > 0 && IntroLoreCount < IntroLoreTotal)
                    {
                      TextPuller = new System.IO.StreamReader(@"source/lore/intro/" + IntroLoreCount + ".txt");
                      while ((PulledText = TextPuller.ReadLine()) != null)
                      {
                          System.Console.WriteLine(PulledText);
                      }                      
                    }
                    else
                    {
                      Console.WriteLine("I apologize for I have nothing more to tell you.");
                    }
                    
                    Console.WriteLine("");
                    Console.WriteLine("Now, what else do you require?");
                    Console.WriteLine("");

                }
                else if(IntroPairChoice == "2")
                {
                    Console.WriteLine("Wait. We're still under maintenance.");
                    Console.WriteLine("");
                    Console.WriteLine("What else could you require?");
                    Console.WriteLine("");
                }
                else if(IntroPairChoice == "3")
                {
                    Console.WriteLine("Very well. Goodbye!");
                }
            }
						

        }
    }
}
