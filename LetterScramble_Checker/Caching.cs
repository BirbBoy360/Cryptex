using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LetterScramble_Checker
{
  public class Caching
  {
    IDictionary<string, bool> _wordCache;
    private void CacheWords()
    {
      var stopwatch = new Stopwatch();
      stopwatch.Start();
      //grab dictionary words from file
      stopwatch.Stop();
      Console.WriteLine($"Time taken to cache words: {stopwatch.ElapsedMilliseconds} ms");
    }
    /* private Func<TIn, TOut> Memoize<TIn, TOut>(this Func<TIn, TOut> func)
    {
      if(_wordCache is null) { _wordCache = new Dictionary<string, bool>(); }
    
      return input =>
      {
        if (_wordCache.ContainsKey(input.ToString()))
        {
          return (TOut)(object)_wordCache[input.ToString()];
        }
        else
        {
          TOut result = func(input);
          _wordCache[input.ToString()] = (bool)(object)result;
          return result;
        }
      };

    } */



  }
}
