/*
4 88 555 999 232 33 3 9 20 34
 */
namespace _03._Reverse_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();
            var reverseArray = numbers.Reverse();
            Console.Write(string.Join(", ", reverseArray));  
        }
    }
}