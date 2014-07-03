namespace CoddingChallengeTwo
{
    using System;

    public class Text
    {
        private string myText = "abc";

        public void read(string fileName) {}

        public int Length()
        {
            return myText.Length;
        }

        public char GetChar(int i)
        {
            Console.WriteLine(i);
            if (i < 0 || i >= Length())
            {
                throw new ArgumentOutOfRangeException();
            }

            return myText[i];
        }
    }
}