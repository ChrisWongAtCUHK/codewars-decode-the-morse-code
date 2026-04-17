namespace Kata.Tests;

public class MorseCodeDecoderTests
{
    [SetUp]
    public void Setup()
    {
    }

    private static readonly Dictionary<string, string> MorseTable = new Dictionary<string, string>
    {
        [".-"] = "A",
        ["-..."] = "B",
        ["-.-."] = "C",
        ["-.."] = "D",
        ["."] = "E",
        ["..-."] = "F",
        ["--."] = "G",
        ["...."] = "H",
        [".."] = "I",
        [".---"] = "J",
        ["-.-"] = "K",
        [".-.."] = "L",
        ["--"] = "M",
        ["-."] = "N",
        ["---"] = "O",
        [".--."] = "P",
        ["--.-"] = "Q",
        [".-."] = "R",
        ["..."] = "S",
        ["-"] = "T",
        ["..-"] = "U",
        ["...-"] = "V",
        [".--"] = "W",
        ["-..-"] = "X",
        ["-.--"] = "Y",
        ["--.."] = "Z",
        ["-----"] = "0",
        [".----"] = "1",
        ["..---"] = "2",
        ["...--"] = "3",
        ["....-"] = "4",
        ["....."] = "5",
        ["-...."] = "6",
        ["--..."] = "7",
        ["---.."] = "8",
        ["----."] = "9",
        [".-.-.-"] = ".",
        ["--..--"] = ",",
        ["..--.."] = "?",
        [".----."] = "'",
        ["-.-.--"] = "!",
        ["-..-."] = "/",
        ["-.--."] = "(",
        ["-.--.-"] = ")",
        [".-..."] = "&",
        ["---..."] = ":",
        ["-.-.-."] = ";",
        ["-...-"] = "=",
        [".-.-."] = "+",
        ["-....-"] = "-",
        ["..--.-"] = "_",
        [".-..-."] = "\"",
        ["...-..-"] = "$",
        [".--.-."] = "@",
        ["...---..."] = "SOS"
    };

    private static string ReferenceDecode(string morse)
    {
        return string.Join(
            " ",
            morse
                .Trim()
                .Split(new[] { "   " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(word =>
                    string.Concat(
                        word.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(code => MorseTable[code])
                    )
                )
        );
    }

    private static readonly List<string> MorseKeys = MorseTable.Keys.ToList();
    private static readonly Random Rng = new Random();

    private static string RandomWord()
    {
        int count = Rng.Next(1, 6);
        var parts = new List<string>(count);
        for (int i = 0; i < count; i++)
        {
            parts.Add(MorseKeys[Rng.Next(MorseKeys.Count)]);
        }
        return string.Join(" ", parts);
    }

    private static string RandomSentence()
    {
        int count = Rng.Next(1, 11);
        var words = new List<string>(count);
        for (int i = 0; i < count; i++)
        {
            words.Add(RandomWord());
        }
        return string.Join("   ", words);
    }

    private static string RandomInput()
    {
        int leading = Rng.Next(0, 11);
        int trailing = Rng.Next(0, 11);
        return new string(' ', leading) + RandomSentence() + new string(' ', trailing);
    }

    [Test]
    [Order(1)]
    public void MorseCodeDecoderBasicTest_1()
    {
        string input = ".-";
        string expected = "A";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(2)]
    public void MorseCodeDecoderBasicTest_2()
    {
        string input = ".";
        string expected = "E";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(3)]
    public void MorseCodeDecoderBasicTest_3()
    {
        string input = "..";
        string expected = "I";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(4)]
    public void MorseCodeDecoderBasicTest_4()
    {
        string input = ". .";
        string expected = "EE";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(5)]
    public void MorseCodeDecoderBasicTest_5()
    {
        string input = ".   .";
        string expected = "E E";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(6)]
    public void MorseCodeDecoderBasicTest_6()
    {
        string input = "...---...";
        string expected = "SOS";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(7)]
    public void MorseCodeDecoderBasicTest_7()
    {
        string input = "... --- ...";
        string expected = "SOS";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(8)]
    public void MorseCodeDecoderBasicTest_8()
    {
        string input = "...   ---   ...";
        string expected = "S O S";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(9)]
    public void MorseCodeDecoderComplexTest_1()
    {
        string input = " . ";
        string expected = "E";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(10)]
    public void MorseCodeDecoderComplexTest_2()
    {
        string input = "   .   . ";
        string expected = "E E";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(11)]
    public void MorseCodeDecoderComplexTest_3()
    {
        string input = "      ...---... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-  ";
        string expected = "SOS! THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
    }

    [Test]
    [Order(12)]
    public void MorseCodeDecoderRandomTests()
    {
        for (int i = 0; i < 50; i++)
        {
            string input = RandomInput();
            string expected = ReferenceDecode(input);
            string actual = MorseCodeDecoder.Decode(input);
            Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for morseCode = \"{input}\"");
        }
    }
}
