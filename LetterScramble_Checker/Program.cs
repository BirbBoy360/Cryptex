using System.Reflection.Metadata;
using LetterScramble_Checker;

internal class Program
{
  static void Main(string[] args)
  {
    Menu menu = new Menu();
    menu.StartNew();
    menu.Run();
    
    //Might be faster to drop all words that are not the same length as the input letters up front
    //or just do it once when the program is run, store them in separate files,
    //and check if a file exists in a given space when the program runs so it doesn't do it twice
  }
}
