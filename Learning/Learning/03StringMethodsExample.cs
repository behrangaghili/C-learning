using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning.Learning
{
    public class StringMethodsExample
    {
        // Method to demonstrate important string methods
        public static void DemonstrateStringMethods()
        {
            string sampleText = "Hello, World!";

            // Length: Gets the number of characters in the string
            Console.WriteLine("Original String: " + sampleText);
            Console.WriteLine("Length of the string: " + sampleText.Length);

            // ToUpper: Converts the string to uppercase
            string upperText = sampleText.ToUpper();
            Console.WriteLine("ToUpper: " + upperText);

            // ToLower: Converts the string to lowercase
            string lowerText = sampleText.ToLower();
            Console.WriteLine("ToLower: " + lowerText);

            // IndexOf: Finds the index of the first occurrence of a character or substring
            int indexOfComma = sampleText.IndexOf(',');
            Console.WriteLine("IndexOf(','): " + indexOfComma);

            // Substring: Extracts a substring starting from a specified index
            string substring = sampleText.Substring(7, 5); // Start at index 7, length of 5
            Console.WriteLine("Substring(7, 5): " + substring);

            // Contains: Checks if the string contains a specified substring
            bool containsWorld = sampleText.Contains("World");
            Console.WriteLine("Contains 'World': " + containsWorld);

            // Replace: Replaces all occurrences of a specified substring with another
            string replacedText = sampleText.Replace("World", "C#");
            Console.WriteLine("Replace 'World' with 'C#': " + replacedText);

            // Split: Splits the string into an array based on a specified delimiter
            string[] splitText = sampleText.Split(',');
            Console.WriteLine("Split by ',': ");
            foreach (string part in splitText)
            {
                Console.WriteLine(part);
            }

            // Trim: Removes leading and trailing whitespace characters
            string textWithWhitespace = "   Trim me!   ";
            string trimmedText = textWithWhitespace.Trim();
            Console.WriteLine("Original text with whitespace: '" + textWithWhitespace + "'");
            Console.WriteLine("Trimmed text: '" + trimmedText + "'");

            // Join: Concatenates an array of strings into a single string with a specified separator
            string[] words = { "Hello", "C#", "World" };
            string joinedText = string.Join(" ", words);
            Console.WriteLine("Join array into string: " + joinedText);

            // Format: Formats a string using placeholders
            string formattedText = string.Format("The original string is: {0}", sampleText);
            Console.WriteLine("Formatted text: " + formattedText);
        }
    }
}
