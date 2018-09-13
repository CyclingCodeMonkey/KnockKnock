using System.Text;

namespace KnockKnock.Web.Services
{
    public class ReverseWordsService : IReverseWordsService
    {
        public string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;

            var length = sentence.Length;
            var output = new StringBuilder();
            for (var i = length - 1; i >= 0; i--)
            {
                output.Append(sentence[i]);
            }

            return output.ToString();
        }
    }
}