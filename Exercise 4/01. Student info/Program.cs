namespace _01._Student_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sumOfGrades = 0;
            int studentCount = 0;
            do
            {
                Console.Write("Enter students count: ");
                studentCount = int.Parse(Console.ReadLine());
            }
            while (studentCount < 0);

            Student[] students = new Student[studentCount]; 
            for(int i = 0; i < studentCount; i++)
            {
                students[i] = new Student();
                Console.Write("Enter first name: ");
                students[i].FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                students[i].LastName = Console.ReadLine();

                bool checkFacultyNumber;

                do
                {
                    checkFacultyNumber = false;
                    Console.Write("Enter faculty number: ");
                    students[i].FacultyNumber = int.Parse(Console.ReadLine());

                    for(int j = 0; j < i; j++)
                    {
                        if (students[i].FacultyNumber == students[j].FacultyNumber)
                        {
                            checkFacultyNumber = true;
                            Console.Write("Faculty number is already exists!");
                            break;
                        }
                    }
                }
                while (checkFacultyNumber);
                Console.Write("Enter average grade: ");
                students[i].Grade = float.Parse(Console.ReadLine());
            }

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{students[i].FirstName} {students[i].LastName}, Faculty Number: {students[i].FacultyNumber}, Average grade: {students[i].Grade:F2}");
                Console.WriteLine();
                sumOfGrades += students[i].Grade;
            }

            Console.WriteLine($"Average grade: {sumOfGrades/studentCount:F2}");

            float referenceGrade;
            do
            {
                Console.Write("Reference for students with average grade above: ");
                referenceGrade = float.Parse(Console.ReadLine());
            }
            while (referenceGrade < 0);

            for(int i = 0; i < studentCount; i++)
            {
                if (students[i].Grade >= referenceGrade)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName}, Faculty Number: {students[i].FacultyNumber}, Average grade: {students[i].Grade:F2}");
                    Console.WriteLine();
                }
            }
        }
    }
    class Person
    {
        public string FirstName, LastName;
    }
    class Student : Person
    {
        public float Grade;
        public int FacultyNumber;
    }

}