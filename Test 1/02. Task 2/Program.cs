namespace _02._Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize;
            do
            {
                Console.Write("Enter matrix size between 2 and 10: ");
                matrixSize = int.Parse(Console.ReadLine());
            }
            while (matrixSize < 2 || matrixSize > 10);

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] minAbsValues = new int[matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                int absoluteMinValue = Math.Abs(matrix[i, 0]);
                for (int j = 1; j < matrixSize; j++)
                {
                    int absoluteValue = Math.Abs(matrix[i, j]);
                    if (absoluteValue < absoluteMinValue)
                    {
                        absoluteMinValue = absoluteValue;
                    }
                }
                minAbsValues[i] = absoluteMinValue;
            }

            Console.WriteLine("The array of absolute min values for each row is: ");
            foreach (int value in minAbsValues)
            {
                Console.Write(value + " ");
            }
        }
    }
}