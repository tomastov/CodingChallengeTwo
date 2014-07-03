namespace CoddingChallengeTwo
{
    using System.Text.RegularExpressions;

    public class Finder
    {
        private readonly TLSDictionary tlsDictionary = new TLSDictionary();

        public int GetNumberOfTlsWithGivenFrequency(string myText, int frequency)
        {
            for (var i = 2; i < myText.Length; i++)
            {
                var tls = myText.Substring(i - 2, 3);
                if (Regex.IsMatch(tls, @"^[a-zA-Z]+$"))
                {
                    tlsDictionary.Add(tls.ToLower());
                }
            }

            return tlsDictionary.FindWithFreq(frequency);
        }
    }
}