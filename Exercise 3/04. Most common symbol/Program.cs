/*
a
e
r
r
t
s
r
t
s
t
r
y
u
i
e
i
a
e
r
t
 */
using System.Collections.Immutable;

namespace _04._Most_common_symbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = new char[20];

            for(int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine(MostCommonSymbol(symbols));
        }

        public static char MostCommonSymbol(char[] symbols)
        {
            return symbols.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .First();
        }
    }
}