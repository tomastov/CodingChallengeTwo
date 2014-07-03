namespace CoddingChallengeTwo
{
    using System.Collections.Generic;

    public class Finder
    {
        private readonly Dictionary<string, int> tlsCount = new Dictionary<string, int>();

        // Finds all TLS with given frequence in a given text
        public int Search(Text myText, int frequency)
        {
            for (var i = 2; i < myText.Length(); i++)
            {
                var tls = GetTLS(myText, 2);
                AddTLS(tls);
            }

            return tlsCount["abc"];
        }

        private void AddTLS(string tls)
        {
            if (tlsCount.ContainsKey(tls))
            {
                tlsCount[tls]++;
            }
            else
            {
                tlsCount.Add(tls, 1);
            }
        }

        // Gets TLS from a given text ending at a given position
        private string GetTLS(Text myText, int position)
        {
            var tls = "";
            for (var i = position; i >= position - 2; i--)
            {
                tls = myText.GetChar(i) + tls;
            }
            return tls;
        }
    }
}