using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public class CartesianScrambler : IScrambler
  {
    //add way to ensure letters is not 0, 1, or null
    private bool Finished = false;
    public string Key = "";
    private List<List<char>> _allOptions;
    public List<List<char>> AllOptions
    {
      //get should return the key to the scrambler
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
    public CartesianScrambler() { }

    public IEnumerable<IEnumerable<T>> Scramble<T>(IEnumerable<IEnumerable<T>> sequences)
    {
      IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
      return sequences.Aggregate(emptyProduct, (accumulator, sequence) =>
        from accSeq in accumulator
        from item in sequence
        select accSeq.Concat(new[] { item })
      );

      /* rewrite
      char[] chars = letters.ToCharArray();
      double comboCount = Math.Pow(letters.Length, letters.Length);
      Console.WriteLine($"Total combinations: {comboCount}");
      */

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
    public bool isFinished() { return Finished == true ? true : false; }
  }
}
