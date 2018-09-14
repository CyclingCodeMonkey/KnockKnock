using System.Text;

namespace KnockKnock.Web.Services
{
    public class ReverseWordsService : IReverseWordsService
    {
        public string Reverse(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return string.Empty;

            var length = sentence.Length;
            var newArray = sentence.ToCharArray();
            var j = length - 1;
            for (var i = 0; i < j; i++, j--)
            {
                var temp = newArray[i];
                newArray[i] = newArray[j];
                newArray[j] = temp;
            }

            return new string(newArray);
        }
    }
}