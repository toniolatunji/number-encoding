using NumberEncoding.Data.Contract;

namespace NumberEncoding.Data.Implementation
{
    public class NumberEncodingData : INumberEncodingData
    {
        public string GetAlphabets()
            => "abcdefghijklmnopqrstuvwxyz";
    }
}
