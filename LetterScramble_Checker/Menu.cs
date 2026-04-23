using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public class Menu
  {
    IScrambler scrambler;

    public void Run()
    {
      string? userChoice = "Exit";
      do
      {
        Console.Write("""
         
         ===== Menu ===== 
         About: Display blurb
         Start: Start new scramble
         """);
        if (scrambler is not null)
        {
          if (scrambler.isFinished() == false)
          {
            Console.WriteLine("""
              Clear: Clear letters
              Display: Display current letters
              Input: Input additional letters
           Read File: Read Letters from File
           """);
          }
          else
          {//if finished
            Console.WriteLine("""
              Display: Display current letters
              Dictionary: Check against dictionary
              Compare: Check against other scramble 
              Write: Write Results to File
           """);
          }
        }
        Console.Write("""
           Help:
           Exit:
           """);
        Console.Write("Choose an option: ");
        userChoice = Console.ReadLine();
        Console.WriteLine();
        MenuSwitch(userChoice); //calls appropriate function and performs auto-completion of command

      } while (userChoice.ToUpper() != "EXIT");
    }

    public void MenuSwitch(string? userChoice)
    {//An explicit switch case would work better but an expression looks so much cleaner
      Action action = userChoice.ToUpper() switch
      {
        "ABOUT" => WriteBlurb,
        "1" => StartNew,
        "2" => ClearLetters,
        "3" => DisplayLetters,
        "4" => InputLetters,
        "5" => CheckScramble,
        "6" => CompareScrambles,
        "7" => GetInputFromFile,
        "8" => WriteResultsToFile,
        "9" => ShowHelp,
        "e" => Exit,
        _ => Invalid
      };
      action();
    }

    private void WriteBlurb()
    {
      Console.WriteLine("""

        Welcome to the Letter Scramble Checker!
        
        This program allows you to input a set of letters and check them against a dictionary to find valid words. 
        It's using multiple lists to hold the letter options per "scramble" and allows you to check the output of one scramble against another to find shared word options. IF they're the same letter count.
        Basically the thought process finding the n-ary cartesian product from a series of letter options (abcdef abcdef abcdef),
          iterating through them and creating a shitton of variations like aaa acf cab dad,
          and then comparing those against a dictionary for words.
        A separate menu option lets you check for words amongst one option string like (abcdef) giving cab as an option but not dad.
        Use the provided options to write to files how you want or provide an input file.

       """
      );
    }

    private void InputLetters()
    {
      /* List<string> letterOptions = new List<string>();
      Console.Write("Please input your first string of letters");
      string input = Console.ReadLine();
      letterOptions.Add(input);
      do
      {
        Console.Write("Please input your next string of letters, or type e to end input: ");
        input = Console.ReadLine();
        if (input != "e") { letterOptions.Add(input); }
      } while (input != "e");

      if (letterOptions.Count == 1)
      {
        //use single scramble  
      }
      else
      {
        //should I process and send or vice versa




        //allLetters.Add( ToList( letterOptions[i].Split()) )
        //char[] temp = letterOptions[i].Split());
        //temp.ToList();
      
      }*/
    }

    private void ClearLetters()
    {
    }

    private void DisplayLetters()
    {
      //display current letters
    }

    public void StartNew()
    {

    }

    private void CheckScramble()
    {

    }
    private void CompareScrambles()
    {

    }
    private void GetInputFromFile()
    {

    }
    private void WriteResultsToFile()
    {

    }
    private void ShowHelp()
    {
      string userChoice;
      do
      {
        Console.Write("To get help for a command, please enter the commands input number or type e to exit the help command" +
          "\nHelp: ");
        userChoice = Console.ReadLine();
        string helpMsg = userChoice switch
        {
          "0" => "This provides a brief description of the program.",
          "1" => "This will start up a new scramble entry, it isn't necessary to choose the first time the program is run." +
                 "\nInstead, use this to start a second scramble after one has been input.",
          "2" => "This option is intended to help undo any mistakes and allow for future re-entry " +
                 "\nor to clear the previous scramble before inputting a new one.",
          "3" => "This just shows what letters have been input for any scramble lists that exist",
          "4" => "Use this command to input extra letters after entry for a scramble list has already been done.",
          "5" => "This will search through a dictionary.txt file to find matches for any of the scramble combinations.",
          "6" => "Using this command will prompt for two different scramble results.txt files to compare. " +
                 "\nYou'll have to know the filenames and file-path in order to use this.",
          "7" => "Instead of entering letters in the console app you can pull them from a file. " +
                 "\nThis works so long as you can specify which of the various formatting options the file is formatted in.",
          "8" => "Results should be automatically written to a file, but if for some reason they weren't, you can use this to specify a file name to write to.",
          "9" => "Hi! you're here.",
          "e" => "Exiting...",
          _ => "Invalid"
        };

        if (helpMsg == "Invalid")
        { Invalid(); ShowHelp(); }

        Console.WriteLine(helpMsg + "\n");
      } while (userChoice != "e");
      return;
    }
    private void Invalid()
    {
      Console.WriteLine("Invalid input, please try again.");
    }
    private void Exit()
    {
      Environment.Exit(0);
    }
    private void RegexComplex(string[] array, Action<string, string, string> action, string checkThis, string replacement)
    {
      foreach (element in array) {  }
    }
  }
}
