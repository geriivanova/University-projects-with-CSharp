namespace _01._Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                int element = int.Parse(Console.ReadLine());
                while (element < -9 || element > 9)
                {
                    Console.WriteLine("Enter correct nmber between -9 and 9");
                    element = int.Parse(Console.ReadLine());
                }
                array[i] = element;
            }

            Console.WriteLine("Array is: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("New array is: ");

            for (int i = 0; i < array.Length; i++)
            {
                string concatArray = array[i].ToString() + "1";
                array[i] = int.Parse(concatArray);
                Console.Write(array[i] + " ");
            }
        }
    }
}