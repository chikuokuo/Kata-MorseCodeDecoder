using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DecodeTheMorseCode1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }

    class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var wordSeparate = morseCode.Trim().Split(new[] { "   " }, StringSplitOptions.None);
            var wordList = wordSeparate.Select(x =>
                x.Split(' ').Aggregate(string.Empty, (result, y) => result + MorseCode.Get(y)));
            return string.Join(" ", wordList);
        }
    }

    class MorseCode
    {
        public static string Get(string p0)
        {
            return "0";
        }
    }
}
