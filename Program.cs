namespace specialchar
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the size of the array
            Console.Write("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());

            // Initialize the character array
            char[] chars = new char[size];

            // Get characters from the user
            Console.WriteLine("Enter the characters:");
            for (int i = 0; i < size; i++)
            {
                chars[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line after each character
            }

            // Get the special character to replace duplicates
            Console.Write("Enter the special character: ");
            char specialChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after special character

            // Call the method to replace duplicates
            ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            // Display the result
            Console.WriteLine("Resulting characters:");
            foreach (var ch in chars)
            {
                Console.WriteLine(ch);
            }

            // Example string output
            Console.WriteLine("string: Hello/");
        }

        public static void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            // Create a hash set to track seen characters
            var seenChars = new HashSet<char>();

            // Iterate through the character array
            for (int i = 0; i < chars.Length; i++)
            {
                // If the character is already in the set, replace it
                if (seenChars.Contains(chars[i]))
                {
                    chars[i] = specialChar; // Replace with special character
                }
                else
                {
                    seenChars.Add(chars[i]); // Add the character to the set
                }
            }
        }
    }

}
