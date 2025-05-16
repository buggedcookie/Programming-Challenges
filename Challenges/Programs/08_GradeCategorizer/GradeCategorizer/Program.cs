namespace GradeCategorizer;

class Program
{
    static void Main(string[] args)
    {
        GradeConverter gradeConverter = new();
        while (true)
        {
            Console.ResetColor();
            
            Console.WriteLine("Tip: Type \"--exit\" to close the program.");
            Console.Write("Enter a grade (as a percentage or letter A, B, C, D, F): ");

            string input = Console.ReadLine() ?? string.Empty;
            input = input.Replace("%", "");

            if (input == "--exit") break;
            if (input == "--clear")
            {
                Console.Clear();
                continue;
            }


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (int.TryParse(input, out int grade))
            {
                Console.WriteLine(
                    $">>> Grade Percentage : {grade}% | Grade Letter: {gradeConverter.FromPercentage(grade).ToLetterGrade()}");
                continue;
            }

            if (gradeConverter.IsValidLetterGrading(input))
            {
                Console.WriteLine(
                    $">>> Grade Letter : {input} | Grade Percentage: ~{gradeConverter.FromLetter(input).ToPercentage()}%");
                continue;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>> Invalid Grade Letter or Grade Percentage");
        }
    }
}