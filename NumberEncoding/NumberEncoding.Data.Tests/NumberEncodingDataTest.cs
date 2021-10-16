using NumberEncoding.Data.Contract;
using NumberEncoding.Data.Implementation;
using NUnit.Framework;

namespace NumberEncoding.Data.Tests
{
    public class NumberEncodingDataTest
    {
        INumberEncodingData numberEncodingData;

        [SetUp]
        public void SetUp()
        {
            numberEncodingData = new NumberEncodingData();
        }

        [Test]
        public void GetAlphabets_Returns_26Characters()
        {
            var alphabets = numberEncodingData.GetAlphabets();

            Assert.That(alphabets.Length, Is.EqualTo(26));
        }

        [TestCase('a', ExpectedResult = 1)]
        [TestCase('j', ExpectedResult = 10)]
        [TestCase('p', ExpectedResult = 16)]
        [TestCase('f', ExpectedResult = 6)]
        [TestCase('v', ExpectedResult = 22)]
        [TestCase('q', ExpectedResult = 17)]
        public int GetCharacterPosition_Returns_CharactersInTheRightPosition(char character)
        {
            var alphabets = numberEncodingData.GetAlphabets();

            var characterPosition = alphabets.IndexOf(character) + 1;

            return characterPosition;
        }
    }
}
