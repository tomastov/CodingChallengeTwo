namespace CoddingChallengeTwo
{
    using System;

    public class Text
    {
        private string myText = "abcabc";

        public void read(string fileName) {}

        public int Length()
        {
            return myText.Length;
        }

        public char GetChar(int i)
        {
            if (i < 0 || i >= Length())
            {
                throw new ArgumentOutOfRangeException();
            }
            return myText[i];
        }
    }
}