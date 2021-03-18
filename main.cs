using System;
using System.IO;
using System.Threading;

namespace Manila_2081
{
    class Program
    {
        static void Main(string[] args)
        {
        //SECTION: Pre-programming Notes
          //1. When initiating new variables, ensure use of CamelCase.
          //2. Be guided by the SECTION headers. They outline the portions of the page.
          //3. (Symbol Guide) ">" stands for Available Choices, ">>" stands for Player Input

        //SECTION: Initalization A (Variables Used Throughout The Program)

            //System.IO.StreamReader is used to pull text from the source folder.
            //System.IO.DirectoryInfo is used to count the amount of files in a certain folder. In this case, it counts how many files there are in the source/lore/intro tab. This is used later in "SECTION: Primary Select Screen" in order to simplify the code.  

            System.IO.StreamReader TextPuller;
            System.IO.DirectoryInfo DirectoryCounter;
            string PulledText = "";

        //SECTION: Initialization B (Variables Used in Introduction)      
            
            int IntroLoreFiles = 0;
            int IntroLoreCount = 0;

            int InvalidInputFiles = 0;
            int IntroInvalidCount = 0;    

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
					  
        //SECTION: Front Desk Dialogue || Welcome

						Console.WriteLine("Padayon, champions! Here you are at the Tondo Dome. What does your heart desire?");
						            
        //SECTION: Primary Select screen

            //The primary select screen loops until you select Exit("1").              
            while(IntroPairChoice != "2")
            {
                //The wording of the choices change according to how many times the LORE(1) option was selected
                if (IntroLoreCount == 0)
                {
                    DirectoryCounter = new System.IO.DirectoryInfo(@"source/lore/intro");
                    IntroLoreFiles = DirectoryCounter.GetFiles().Length;

                    //As in, this one is the base (When you haven't asked for any lore yet)...
                    TextPuller = new System.IO.StreamReader(@"source/text/intro/choices1.txt");
                    while ((PulledText = TextPuller.ReadLine()) != null)
                    {
                    System.Console.WriteLine(PulledText);
                    }
                    
                }
                else
                {
                    //...and this one is for when you have already asked for lore, and are given the option to ask again.
                    TextPuller = new System.IO.StreamReader(@"source/text/intro/choices2.txt");
                    while ((PulledText = TextPuller.ReadLine()) != null)
                    {
                    System.Console.WriteLine(PulledText);
                    }
                }

                Console.WriteLine("");
                Console.Write(">> Select a Choice: ");
                IntroPairChoice = Console.ReadLine();
                Console.WriteLine("");

        //SECTION: Front Desk Dialogue || Lore
                if(IntroPairChoice == "1")
                {
                    
                    //IntroLoreCount is increased by 1.
                    IntroLoreCount++;
                    
                    //This evaluates whether or not the amount of lore files can still supply the amount of times the player asks for lore. If they still can, the program displays the 'nth' text file correspondent to the value assigned to IntroLoreCount. If there are no more lore files, the front desk rejects the request.

                    if(IntroLoreCount <= IntroLoreFiles)
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
                    Console.WriteLine("Now, do you need anything else?");
                    Console.WriteLine("");

                }

        //SECTION: Front Desk Dialogue || Combat              
                else if(IntroPairChoice == "2")
                {
                    Console.WriteLine("Wait. We're still under maintenance. Leave for now.");
                    Console.WriteLine("");
                }
        
        //SECTION: Front Desk Dialogue || Exit
                else if(IntroPairChoice == "3")
                {
                    Console.WriteLine("Very well. Goodbye!");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
        
        //SECTION: Front Desk Dialogue || Invalid
                //This part is an easter egg for people who don't know how to pick from 1 to 3. I shake my head.
                else{                    
                   
                   IntroInvalidCount++;
                    
                    if(IntroInvalidCount > 0 && IntroInvalidCount <= InvalidInputFiles)
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
                    Console.WriteLine("Now, do you need anything else?");
                    Console.WriteLine("");

                    if(IntroInvalidCount == 1)
                    {
                      Console.WriteLine("Uhhhhhhhhh. I don't think I gave that option. Choose again, champion.");
                      Console.WriteLine("");
                    }
                    else if(IntroInvalidCount == 2)
                    {
                      Console.WriteLine("I... really don't think I gave that option, champion. Can you please choose something valid?");
                      Console.WriteLine("");
                    }
                    else if(IntroInvalidCount == 3)
                    {
                      Console.WriteLine("If you don't speak, you'll have to leave.");
                    }
                    else
                    {
                      Console.WriteLine("You know what? Go away; you're banned now. Farewell.");
                      System.Threading.Thread.Sleep(3000);
                      Environment.Exit(0);
                    }
                }                      
            }				
          Console.WriteLine("Work in Progress. This is the part where the battle happens!");    
        }
    }
}
