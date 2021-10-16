using NumberEncoding.Data.Contract;
using NumberEncoding.Service.Contract;

namespace NumberEncoding.Service.Implementation
{
    public class NumberEncodingService : INumberEncodingService
    {
        private readonly INumberEncodingData numberEncodingData;

        public NumberEncodingService(INumberEncodingData numberEncodingData)
        {
            this.numberEncodingData = numberEncodingData;
        }

        public string NumberEncoding(string str)
        {
            var response = "";

            var alphabets = numberEncodingData.GetAlphabets();

            var input = str.ToLower();

            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    var charPosition = alphabets.IndexOf(character) + 1;

                    response += charPosition;
                }
                else
                {
                    response += character;
                }
            }

            return response;
        }
    }
}
