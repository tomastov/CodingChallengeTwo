namespace CoddingChallengeTwo
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a frequency: ");
            var frequency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var fname = @"C:\Users\tov\Desktop\CodingChallengeTwo\CoddingChallengeTwo\tls.txt";

            var reader = new Reader();
            var myText = reader.ReadFromFile(fname);

            var finder = new Finder();
            var numberOfTls = finder.GetNumberOfTlsWithGivenFrequency(myText, frequency);

            Console.Write("There are {0} TLSs that appear in this document exactly {1} times.", numberOfTls, frequency);
            Console.ReadLine();
        }
    }
}