namespace _01.Count_of_vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = 0;
            text = text.ToLower();
            for(int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'а':
                    case 'ъ':
                    case 'о':
                    case 'у':
                    case 'е':
                    case 'и':
                    case 'ю':
                    case 'я':
                        count++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}