namespace ChallengeStringMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            // Reads input string
            string input = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            // Read the character input to search
            char searchInput = Console.ReadLine()[0];
            // Gets the index of the character entered in the string
            int searchIndex = input.IndexOf(searchInput);
            // Prints the index as a search result on console
            Console.WriteLine($"Index of the character {searchInput} in the string is {searchIndex}");
            // Read the first name
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            // Read the last name
            string lastName = Console.ReadLine();
            //Concatinates the firstName and lastName variable, assigning it to fullName
            string fullName = string.Concat(firstName," ", lastName);
            // Prints the full name on the console.
            Console.WriteLine("Your full name is: {0}", fullName);
            Console.Read();
        }
    }
}