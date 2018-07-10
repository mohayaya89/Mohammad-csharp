using Palindrome.Library.Abstract;

namespace Palindrome.Library.Abstract
{
    public class PalCodeNumber : ANumber
    {
      public PalCodeNumber()
      {
        PalNumber = 122;
      }

      public override string ToString()
      {
        return $"{PalNumber}";
      }
    }
}