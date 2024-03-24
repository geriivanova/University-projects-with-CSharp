using System.Linq.Expressions;

namespace _01._Count_of_vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int countOfVowels = 0;

            for(int i = 0; i < word.Length; i++)
            {
                switch(word[i])
                {
                    case 'а':
                        countOfVowels++;
                        break;
                    case 'ъ':
                        countOfVowels++;
                        break;
                    case 'о':
                        countOfVowels++;
                        break;
                    case 'у':
                        countOfVowels++;
                        break;
                    case 'е':
                        countOfVowels++;
                        break;
                    case 'и':
                        countOfVowels++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(countOfVowels);
        }
    }
}