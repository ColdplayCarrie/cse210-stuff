//I gave the user the option to choose from three different scriptures.

using System;

class Program
{
    static void Main(string[] args)
    {
        int userChosenScripture;
        Reference chosenReference;
        Scripture chosenScripture;

        //hard code reference
        Reference reference1 = new Reference("Phillipians", 4, 13);
        Reference reference2 = new Reference("Mormon", 8, 35);
        Reference reference3 = new Reference("Mormon", 7, 3, 4);
        
        //hard code scripture reference and text
        Scripture scripture1 = new Scripture(reference1, "I can do all things through Christ which strengtheneth me.");
        Scripture scripture2 = new Scripture(reference2, "Behold, I speak unto you as if ye were present, and yet ye are not. But behold, Jesus Christ hath shown you unto me, and I know your doing.");
        Scripture scripture3 = new Scripture(reference3, "Know ye that ye are of the house of Israel. Know ye that ye must come unto repentance, or ye cannot be saved.");
        
        //create scripture container space (memory)
        List<Scripture> _scriptures = new List<Scripture>();

        _scriptures.Add(scripture1);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);

        while(true) 
        {
            Console.WriteLine("Choose a scripture (1, 2, or 3) and type in the number: ");
            userChosenScripture = int.Parse(Console.ReadLine());

            if (userChosenScripture == 1)
            {
                chosenReference = reference1;
                chosenScripture = scripture1;
                break;
                
            }
            else if (userChosenScripture == 2)
            {
                chosenReference = reference2;
                chosenScripture = scripture2;
                break;
            }
            else if (userChosenScripture == 3)
            {
                chosenReference = reference3;
                chosenScripture = scripture3;
                break;
            }
            else
            {
                Console.WriteLine("ERROR: Enter number 1, 2, or 3");
            }
        }

        //Display the scripture
        Console.WriteLine(chosenReference.GetDisplayText());
        Console.WriteLine(chosenScripture.GetDisplayText());
        Console.WriteLine("Hit the Enter key to hide words. Type quit to end.");
        string userInput = Console.ReadLine();

        if (userInput == "quit")
        {
            Console.WriteLine("Have a great day!");
        }
        else
        {
            //Clear the console
            Console.Clear();

            do
            {
                chosenScripture.HideRandomWords(2);
                Console.WriteLine(chosenReference.GetDisplayText());
                Console.WriteLine(chosenScripture.GetDisplayText());
                Console.WriteLine("Hit the Enter key to hide words. Type QUIT to end.");
                string newUserInput = Console.ReadLine();
                
                if (newUserInput == "quit")
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }
                else
                {
                    //Clear the console
                    Console.Clear();
                }
            } while (!chosenScripture.IsCompletelyHidden());
        }

    }
}