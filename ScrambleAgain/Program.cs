namespace ScrambleAgain
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string? userChoice = "e";
      do
      {
        Console.WriteLine("""
            ===== Menu ===== 
            0.Display blurb
            1.Start new scramble
            2.Clear letters
            3.Display current letters
            4.Input additional letters
            5.Check against dictionary
            6.Check against other scramble 
            7.Read Letters from File
            8.Write Results to File
            9.Help
            e.Exit
           """);
        Console.Write("Choose an option: ");
        userChoice = Console.ReadLine();
        MenuSwitch(userChoice);

      } while (userChoice != "e");
    
    }
    public void MenuSwitch(string? userChoice)
    {//An explicit switch case would work better but an expression looks so much cleaner
      Action action = userChoice switch
      {
        "0" => WriteBlurb,
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
  }
}
