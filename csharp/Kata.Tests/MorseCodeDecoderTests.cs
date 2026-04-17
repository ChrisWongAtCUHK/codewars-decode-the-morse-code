namespace Kata.Tests;

public class MorseCodeDecoderTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MorseCodeDecoderBasicTest_1()
    {
        string input = ".... . -.--   .--- ..- -.. .";
        string expected = "HEY JUDE";

        string actual = MorseCodeDecoder.Decode(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
