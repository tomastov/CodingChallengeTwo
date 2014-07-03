namespace CoddingChallengeTwo
{
    using System;
    using System.Collections.Generic;

    public class Finder
    {
        private readonly Dictionary<string, int> tlsCount = new Dictionary<string, int>();

        public int GetNumberOfTLSWithGivenFrequency(Text myText, int frequency)
        {
            for (var i = 2; i < myText.Length; i++)
            {
                var tls = GetTLS(myText, i);
                if (tls != "")
                {
                    AddTLS(tls);
                }
            }

            return FindWithFreq(frequency);
        }

        private int FindWithFreq(int frequency)
        {
            var count = 0;
            foreach (var kvp in tlsCount)
            {
                if (kvp.Value == frequency)
                {
                    count++;
                    Console.WriteLine(kvp.Key);
                }
            }
            return count;
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
        // If there is not TLS at this position returns ""
        private string GetTLS(Text myText, int position)
        {
            var tls = "";
            for (var i = position; i >= position - 2; i--)
            {
                if (Char.IsLetter(myText.GetChar(i)))
                {
                    tls = Char.ToLower(myText.GetChar(i)) + tls;
                }
                else
                {
                    tls = "";
                    break;
                }
            }

            return tls;
        }
    }
}