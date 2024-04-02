namespace Loops_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for a sentence and counts spaces within the sentence
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            //Asks for number and adds the value of the digits in the number
            Console.WriteLine("Please enter a whole number");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        static int CountNumberOfSpaces(string sentence)
        {
            //Method that counts spaces in the sentence
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if (character == ' ')
                    numberOfSpaces++;
            }
            return numberOfSpaces;
        }

        static int SumOfDigits(string number)
        {
            //Method that adds digits of the whole number entered
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
