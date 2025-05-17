namespace SimpleCalculator;

class Calculator
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtraction(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
    
    static double Modulo(double a, double b)
    {
        return a % b;
    }
    
    public static double? Solve(string expression)
    {
        var args = expression.Split(" ");
        // 1 + 1

        if(args.Length < 3) return null;
        
        return (args[1]) switch
        {
            "+" => Add(double.Parse(args[0]), double.Parse(args[2])),
            "-" => Subtraction(double.Parse(args[0]), double.Parse(args[2])),
            "*" => Multiply(double.Parse(args[0]), double.Parse(args[2])),
            "/" => Divide(double.Parse(args[0]), double.Parse(args[2])),
            "%" => Modulo(double.Parse(args[0]), double.Parse(args[2])),
            _ => 0d
        };
    }
}
