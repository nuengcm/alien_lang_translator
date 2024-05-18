using System.Text;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        // ** unit tests ** //
        //Console.WriteLine(TranslateToAlienLanguage("Hello World"));
        //Console.WriteLine(TranslateToAlienLanguage("Lorem ipsum dolor sit amet, consectetur adipiscing elit."));
        //Console.WriteLine(TranslateToAlienLanguage(null));
        //Console.WriteLine(TranslateToAlienLanguage(""));
        //Console.WriteLine(TranslateToAlienLanguage(" "));

        string text;
        Console.WriteLine("Fill the text you want to translate.\r\n (Type /exit to exit the program.)");        

        while (true)
        {
            Console.Write(": ");
            text = Console.ReadLine();            
            if (text.Equals("/exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Good bye...");
                break;
            }
            Console.WriteLine(TranslateToAlienLanguage(text));
            Console.WriteLine();
        }
    }

    public static string TranslateToAlienLanguage(string text)
    {
        string result = "";
        int wordCount = 0, shiftNumber = 1;
        string vowels = "aeiouAEIOU"; // all vowels
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"; // all consonants
        StringBuilder translation = new StringBuilder("UBCO "); // initialize start with "UBCO ".
        if (!string.IsNullOrEmpty(text) && text.Length > 0)
        {
            foreach (char c in text)
            {
                shiftNumber = 1;
                if (vowels.Contains(c)) // Is it a vowel?
                {
                    translation.Append(c, 2);
                }
                else if (consonants.Contains(c)) // Is it a consonant?
                {
                    if (vowels.Contains((char)((int)c + 1)))
                    {
                        shiftNumber = shiftNumber + 1;
                    }
                    translation.Append((char)((int)c + shiftNumber));
                }
                else // All other characters.
                {
                    translation.Append(c);
                    if (c == ' ')
                    {
                        wordCount++;
                    }
                }
            }
        }

        // Add 1 to word count if text is not empty.
        if(text != null) { 
            if (!string.IsNullOrEmpty(text.Trim()))
            {
                wordCount++;
            }
        }

        translation.Append(wordCount);
        if(wordCount > 0)
            result = translation.ToString();
        return result;
    }
}