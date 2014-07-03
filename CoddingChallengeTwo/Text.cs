namespace CoddingChallengeTwo
{
    using System;
    using System.IO;

    public class Text
    {
        private string myText;

        public int Length
        {
            get { return myText.Length; }
        }
        public void Read(string fileName)
        {
            myText = File.ReadAllText(fileName);
        }
        public char GetChar(int i)
        {
            if (i < 0 || i >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            return myText[i];
        }
    }
}