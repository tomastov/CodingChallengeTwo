namespace CoddingChallengeTwo
{
    using System;
    using System.Collections.Generic;

    internal class TLSDictionary
    {
        private readonly Dictionary<string, int> tlsDictionary = new Dictionary<string, int>();

        public void Add(string tls)
        {
            if (tlsDictionary.ContainsKey(tls))
            {
                tlsDictionary[tls]++;
            }
            else
            {
                tlsDictionary.Add(tls, 1);
            }
        }

        public int FindWithFreq(int frequency)
        {
            var count = 0;
            foreach (var kvp in tlsDictionary)
            {
                if (kvp.Value == frequency)
                {
                    count++;
                    Console.WriteLine(kvp.Key);
                }
            }
            return count;
        }
    }
}