using Palindrome.Library.Abstract;

namespace PalCodeWord
{
    public class PalCodeWord : AWord
    {
      public PalCodeWord()
      {
        PalWord = "civic";
      }

      public override string ToString() 
      {
        return $"{PalWord}";
      }
      
    }
}