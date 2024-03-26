namespace _12._Is_string_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverseString = string.Empty;

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reverseString += word[i];
            }

            if(reverseString == word)
            {
                Console.WriteLine($"{word} is palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not palindrome");
            }
        }
    }
}