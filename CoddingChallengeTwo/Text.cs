namespace CoddingChallengeTwo
{
    using System;
    using System.IO;

    public class Text
    {
        private string myText;

        public void read(string fileName)
        {
            myText = File.ReadAllText(fileName);
        }

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