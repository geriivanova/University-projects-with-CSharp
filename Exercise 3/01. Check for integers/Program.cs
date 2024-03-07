namespace _01._Check_for_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            double average = 0;

            for(int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out array[i]);    
            }
            average = array.Average();
            Console.WriteLine(average); 
        }
    }
}