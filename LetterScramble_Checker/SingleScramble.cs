using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public class SingleScramble : IScrambler
  {
    //add way to turn List<List<char>> into just List<char> while still implementing IScrambler and not breaking
    public bool Finished = false;
    public string Key = "";
    private List<List<char>> _allOptions;
    public List<List<char>> AllOptions
    {
      //get should return the key to the scrambler?
      get { return _allOptions; }

      //Whenever options for a scramble are changed, the inner lists are sorted and a key is created or changed
      set
      {
        for (int i = 0; i < value.Count(); i++)
        {
          value[i].Sort();
        }
        _allOptions = value;
        KeyMaker(value);
      }
    }
    

    public SingleScramble() { }

    public IEnumerable<IEnumerable<T>> Scramble<T>(IEnumerable<IEnumerable<T>> sequences)
    {
      throw new NotImplementedException();
    }

    private void KeyMaker(List<List<char>> optionLists)
    {
      for (int i = 0; i < _allOptions.Count(); i++)
      {
        string stringedOptions = "";
        List<char> theseOptions = _allOptions[i];
        for (int k = 0; k < theseOptions.Count; k++)
        {
          stringedOptions += theseOptions[k];
        }
        Key += stringedOptions + i;
      }
    }
    public void AddOptions(int? index)
    {
      if (index == null)
      {
        Console.WriteLine("Adding new string of options to the scramble");
      }
      else
      {
        Console.WriteLine("Adding new options to the option string '' ");
      }
    }
    public void ClearOptions(int? index)
    {
      if (index == null)
      {
        Console.WriteLine("Clearing all options of the scramble");
      }
      else
      {
        Console.WriteLine("Clearing the option string '' ");
      }
    }
    public bool isFinished() { return Finished == true ? true : false; }
  }
}
