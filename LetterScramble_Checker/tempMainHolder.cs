using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public class temp
  {
    public void OverWriteHandler() {
      Console.WriteLine("Current scramble exists... SAVE under id or OVERwrite?");
      string userChoice = Console.ReadLine();
      
      Action action = userChoice.ToLower() switch
      {
        "s" or "save" => Save,
        "o" or "over" or "overwrite" or "write" => OverWrite,
        _ => Invalid
      };
      action();
    }
    public void Save() { }
    public void OverWrite() { }
    public void Invalid() { }
  }
}
