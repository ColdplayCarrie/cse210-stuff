//I added in a lot of decorative things throughout the program to make things easier to read and look better. For example, I added "--->" in the Listing Activity and the Reflecting Activity. 
//I also added spaces between sentences and at the beginning of things (like in the breathing activity). I know that's not much but it's something :)
using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        int userSelect;

        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu: ");
            userSelect = int.Parse(Console.ReadLine());

                if(userSelect==1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity promotes calm, peace, and relaxation as you slowly breathe in and slowly breathe out.", 0);
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                }

                else if (userSelect==2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                }

                else if (userSelect==3)
                {
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity is designed to help you to think about the good things in life by listing as many things as you can pertaining to a specific topic.", 0, 0);
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                }
        }while (userSelect!=4);

        if (userSelect==4);
        {
            Console.WriteLine();
            Console.WriteLine("Peace Out \\/");
            Console.WriteLine();
        }
    }
}