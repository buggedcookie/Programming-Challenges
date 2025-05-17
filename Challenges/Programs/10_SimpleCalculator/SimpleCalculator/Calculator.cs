namespace SimpleCalculator;

class Calculator
{
    static double Add(int a, int b)
    {
        return a + b;
    }

    static double Subtraction(int a, int b)
    {
        return a - b;
    }

    static double Multiply(int a, int b)
    {
        return a * b;
    }

    static double Divide(int a, int b)
    {
        return a / b;
    }
    
    static double Modulo(int a, int b)
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
            "+" => Add(int.Parse(args[0]), int.Parse(args[2])),
            "-" => Subtraction(int.Parse(args[0]), int.Parse(args[2])),
            "*" => Multiply(int.Parse(args[0]), int.Parse(args[2])),
            "/" => Divide(int.Parse(args[0]), int.Parse(args[2])),
            "%" => Modulo(int.Parse(args[0]), int.Parse(args[2])),
            _ => 0d
        };
    }
}