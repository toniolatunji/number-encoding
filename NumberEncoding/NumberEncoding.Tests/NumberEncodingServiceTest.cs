using Moq;
using NumberEncoding.Data.Contract;
using NumberEncoding.Service.Contract;
using NumberEncoding.Service.Implementation;
using NUnit.Framework;

namespace NumberEncoding.Tests
{
    public class NumberEncodingServiceTest
    {
        Mock<INumberEncodingData> mockNumberEncodingData;

        [SetUp]
        public void Setup()
        {
            mockNumberEncodingData = new Mock<INumberEncodingData>();

            mockNumberEncodingData.Setup(n => n.GetAlphabets()).Returns("abcdefghijklmnopqrstuvwxyz");
        }

        [TestCase("hello 45", ExpectedResult = "85121215 45")]
        [TestCase("jaj-a", ExpectedResult = "10110-1")]
        public string NumberEncoding_Returns_CorrectEncodingValue(string input)
        {
            INumberEncodingService numberEncodingService = new NumberEncodingService(mockNumberEncodingData.Object);

            return numberEncodingService.NumberEncoding(input);
        }
    }
}
