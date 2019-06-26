using System.Text.RegularExpressions;

namespace RA.WindowsClient.Helpers
{
    public class FormHelper
    {
        public const string REGEX_NUMBER = "[0-9]+";

        public static bool IsLastCharDigit(string text)
        {
            Regex regex = new Regex(REGEX_NUMBER);
            if (!regex.IsMatch(text))
                return true;

            return false;
        }
    }
}
