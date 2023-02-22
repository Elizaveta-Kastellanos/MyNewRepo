using System.Text;

namespace Userinterface.Framework.Utils
{
    public static class RandomUtils
    {
        private const int MinLen = 4;
        private const int MaxLen = 6;
        private static readonly char[] lettersEn = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] lettersRu = "абвгдеёжзийклмнопрстуфхцчшщьъэюя".ToCharArray();
        private static readonly char[] lettersNumber = "0123456789".ToCharArray();

        public static string GetMixedRuEnAndNumText()
        {
            var random = new Random();
            var randomString = new StringBuilder();
            randomString.Append(lettersEn[random.Next(lettersEn.Length)].ToString().ToUpper());
            for (var i = 0; i < random.Next(MinLen, MaxLen); i++)
            {
                randomString.Append(lettersEn[random.Next(lettersEn.Length)]);
                randomString.Append(lettersRu[random.Next(lettersRu.Length)]);
                randomString.Append(lettersNumber[random.Next(lettersNumber.Length)]);
            }
            return randomString.ToString().Trim();
        }

        public static string GetRandomTextFromSetText(string text)
        {
            var random = new Random();
            var randomString = new StringBuilder();
            for(var i = 0; i<text.Length; i++)
            {
                randomString.Append(text[random.Next(text.Length)]);
            }
            return randomString.ToString().Trim();
        }

        public static string GetRandomEnglishText()
        {
            var random = new Random();
            var randomString = new StringBuilder();
            for (var i = 0; i < random.Next(MinLen, MaxLen); i++)
            {
                randomString.Append(lettersEn[random.Next(lettersEn.Length)]);
            }
            return randomString.ToString().Trim();
        }

        public static int GetRandomNumber(int count)
        {
            var random = new Random();
            return random.Next(count);
        }
    }
}
