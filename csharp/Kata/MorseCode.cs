namespace Kata;

// Conceptual implementation of the preloaded MorseCode class
public class MorseCode
{
  private static readonly Dictionary<string, string> _morseMap = new()
  {
        {".-", "A"}, {"-...", "B"}, {"-.-.", "C"}, {"-..", "D"}, {".", "E"},
        {"..-.", "F"}, {"--.", "G"}, {"....", "H"}, {"..", "I"}, {".---", "J"},
        {"-.-", "K"}, {".-..", "L"}, {"--", "M"}, {"-.", "N"}, {"---", "O"},
        {".--.", "P"}, {"--.-", "Q"}, {".-.", "R"}, {"...", "S"}, {"-", "T"},
        {"..-", "U"}, {"...-", "V"}, {".--", "W"}, {"-..-", "X"}, {"-.--", "Y"},
        {"--..", "Z"}, {"-----", "0"}, {".----", "1"}, {"..---", "2"}, {"...--", "3"},
        {"....-", "4"}, {".....", "5"}, {"-....", "6"}, {"--...", "7"}, {"---..", "8"},
        {"----.", "9"}, {".-.-.-", "."}, {"--..--", ","}, {"---...", ":"}, {"..--..", "?"},
        {".----.", "'"}, {"-....-", "-"}, {"-..-.", "/"}, {".--.-.", "@"}, {"-...-", "="},
        {"...---...", "SOS"} // Example of a special service code
    };

  public static string Get(string code)
  {
    // Internal logic simply looks up the string in the map
    return _morseMap.ContainsKey(code) ? _morseMap[code] : string.Empty;
  }
}
