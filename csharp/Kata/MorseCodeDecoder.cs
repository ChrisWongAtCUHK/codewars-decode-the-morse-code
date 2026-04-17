namespace Kata;

public class MorseCodeDecoder
{
  public static string Decode(string morseCode)
  {
    // you can use the preloaded MorseCode:
    // var letter = MorseCode.Get(morse);
    // Split by exactly three spaces
    string[] words = morseCode.Split(["   "], StringSplitOptions.None);

    var decodedWords = new List<string>();

    // Decode each word
    foreach (string word in words)
    {
      string[] letters = word.Split(' ');
      var decodedLetters = new List<string>();

      // Decode each letter in the word
      foreach (string letter in letters)
      {
        decodedLetters.Add(MorseCode.Get(letter));
      }

      decodedWords.Add(string.Join("", decodedLetters));
    }

    return string.Join(" ", decodedWords);
  }
}
