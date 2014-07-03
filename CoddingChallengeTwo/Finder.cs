namespace CoddingChallengeTwo
{
    using System.Collections.Generic;

    public class Finder
    {
        private Dictionary<string, int> TLScount;

        // Finds all TLS with given frequence in a given text
        public int Search(Text myText, int frequency)
        {
            for (var i = 2; i < myText.Length(); i++)
            {
                var TLS = GetTLS(myText, 2);
                TLScount[TLS] = TLScount[TLS] + 1;
            }

            return TLScount["abc"];
        }

        // Gets TLS from a given text ending at a given position
        private string GetTLS(Text myText, int position)
        {
            var TLS = "";
            for (var i = position; i >= position - 2; i--)
            {
                TLS = myText.GetChar(i) + TLS;
            }
            return TLS;
        }
    }
}