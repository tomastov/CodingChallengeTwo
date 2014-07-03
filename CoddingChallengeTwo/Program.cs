namespace CoddingChallengeTwo
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the file name: ");
            var fileName = Console.ReadLine();
            Console.Write("Enter a frequency: ");
            var frequency = Convert.ToInt32(Console.ReadLine());

            var myText = new Text();
            myText.read(fileName);

            var finder = new Finder();
            var numberOfTLS = finder.Search(myText, frequency);

            Console.Write("There are {0} TLSs that appear in this document exactly {1} times.", numberOfTLS, frequency);
            Console.ReadLine();
        }
    }
}