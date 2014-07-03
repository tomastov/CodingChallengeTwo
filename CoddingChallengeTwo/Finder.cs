namespace CoddingChallengeTwo
{
    using System;
    using System.Collections.Generic;

    public class Finder
    {
        private Dictionary<string, int> TLScount;

        // Finds all TLS with given frequence in a given text
        public int Search(Text myText, int frequency)
        {
            // for (var i = 2; i < myText.Length(); i++)
            // {
            var TLS = GetTLS(myText, 2);
            Console.Write(TLS);
            return 1;

            // }
        }

        private string GetTLS(Text myText, int i)
        {
            var TLS = "";
            for (var j = i; j >= j - 2; j--)
            {
                TLS = myText.GetChar(j) + TLS;
            }
            return TLS;
        }
    }
}