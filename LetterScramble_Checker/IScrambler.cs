using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterScramble_Checker
{
  public interface IScrambler
  {
    public IEnumerable<IEnumerable<T>> Scramble<T>(IEnumerable<IEnumerable<T>> sequences);
    public bool isFinished();
  }
}
