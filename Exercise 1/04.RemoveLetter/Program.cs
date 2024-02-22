namespace _04.RemoveLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (letter == c)
                {
                    int index = word.IndexOf(c);
                    word = word.Remove(index, 1);
                }
            }
            Console.WriteLine(word);
        }
    }
}