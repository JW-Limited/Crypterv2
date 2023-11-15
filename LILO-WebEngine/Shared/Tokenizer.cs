using System.Text;

namespace LILO_WebEngine.Shared
{
    public class Tokenizer
    {
        int length, nomSChar = 0;

        public Tokenizer(int length, int nomSChar)
        {
            this.length = length;
            this.nomSChar = nomSChar;
        }

        private static readonly char[] tokenChars =
        {
              'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
              'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
              '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        public string GenerateRandomToken()
        {
            if (length < 12)
            {
                throw new ArgumentException("The password length must be at least 12 characters.");
            }

            if (nomSChar < 1)
            {
                throw new ArgumentException("The number of special characters must be at least 1.");
            }

            StringBuilder passwordBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int characterIndex = random.Next(tokenChars.Length);
                passwordBuilder.Append(tokenChars[characterIndex]);
            }

            return passwordBuilder.ToString();
        }
    }
}
