using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public static class Cartesians
  {
    public static IEnumerable<IEnumerable<T>> CartesianProducts<T>(this IEnumerable<IEnumerable<T>> sequences)
    {
      IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
      return sequences.Aggregate(emptyProduct, (accumulator, sequence) =>
        from accSeq in accumulator
        from item in sequence
        select accSeq.Concat(new[] { item })
      );
    }
  }
}
