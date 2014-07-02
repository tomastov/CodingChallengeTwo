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

            var numberOfTLS = 10;

            Console.Write("There are {1} TLSs that appear in this document exactly {2} times.", numberOfTLS, frequency);
        }
    }
}