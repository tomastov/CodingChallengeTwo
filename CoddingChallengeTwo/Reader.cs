namespace CoddingChallengeTwo
{
    public class Reader
    {
        public string ReadFromFile(string fname)
        {
            return System.IO.File.ReadAllText(fname);
        }
    }
}