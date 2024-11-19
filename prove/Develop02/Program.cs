//I added option 6 which permanently deletes the contents of the journal file the user chooses

using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
       
    static void Main(string[] args)
    {
                
        Journal journal = new Journal();
        PromptGenerator pg = new PromptGenerator();

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        int userSelect;
        int userResponse;

        do
        {            
            Console.WriteLine("");
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Load your journal");
            Console.WriteLine("4. Save your journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Delete your journal");
            Console.WriteLine("");
            Console.Write("What would you like to do? ");
            userSelect = int.Parse(Console.ReadLine());

                if(userSelect==1) 
                {
                    Entry entry = new Entry();
                    DateTime date = DateTime.Now;
                    entry._date = date.ToShortDateString();
                    Console.WriteLine("");
                    Console.WriteLine("Hit the <Enter> key when you finish recording your journal entry.");
                    Console.Write("Here is your prompt: ");    
                    string _promptText = pg.GetRandomPrompt();
                    Console.WriteLine(_promptText);
                    entry._promptText = _promptText;
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                }
                
                else if (userSelect ==2) 
                {
                    journal.DisplayAll();
                    Console.WriteLine("");
                }

                else if (userSelect ==3)
                {
                    Console.Write("What is the name of the file you would like to load? ");
                    string _loadUserFile = Console.ReadLine();
                    journal.LoadFromFile(_loadUserFile);
                    Console.WriteLine("");
                }

                else if (userSelect ==4)
                {
                    Console.Write("Please enter the name of the file: ");
                    string _fileName = Console.ReadLine();
                    using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(_fileName))
                    {            
                        outputFile.WriteLine(outputFile);
                    }
                    journal.SaveToFile(_fileName); 
                }

                else if (userSelect == 6)
                {
                    Console.WriteLine("");
                    Console.WriteLine("If you wish to PERMANENTLY delete the contents of your journal, please enter the number 1.");
                    Console.WriteLine("Choosing this option will PERMANENTLY delete the contents your journal. It will not be recoverable in any universe.");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to PERMANENTLY delete the contents of your journal?");
                    Console.Write("Enter the 1 if you want to delete your journal. Enter 2 if you do not want to delete your journal: ");
                    userResponse = int.Parse(Console.ReadLine());

                    if (userResponse != 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your journal was not deleted. Please continue.");
                    }

                    else if (userResponse == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("What is the name of the journal file you wish to permanently delete the contents of? ");
                        string deleteMyJournal = Console.ReadLine();
                        Console.WriteLine("Please re-enter the name of the file: ");
                        string confirmDeleteMyJournal = Console.ReadLine();
                        File.WriteAllText(deleteMyJournal, string.Empty);
                        Console.WriteLine("");
                        Console.WriteLine("Your journal has been permanently deleted. o7");
                    }
                } 
             

        }  while (userSelect !=5);

        if (userSelect == 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the Journal Program. Have a great day!");
            Console.WriteLine("");
        }
    }
    
}