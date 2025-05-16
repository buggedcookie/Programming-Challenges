using System.Runtime.CompilerServices;

namespace GradeCategorizer;

public class GradeConverter
{
    private float _percentage;

    private Dictionary<string, int> _averageLetterGrade = new()
    {
        {"F", 59}, // <= 59
        {"D", 69}, // <= 69
        {"C", 79}, // <= 79
        {"B", 89}, // <= 89
        {"A", 100}, // <= 100
    };

    public GradeConverter FromPercentage(int percentage)
    {
        _percentage = percentage;
        return this;
    }

    public bool IsValidLetterGrading(string input)
    {
        input = input.ToUpper();
        return _averageLetterGrade.ContainsKey(input);
    }
    
    public GradeConverter FromLetter(string grade)
    {
        grade = grade.ToUpper();

        _averageLetterGrade.TryGetValue(grade, out var value);
        _percentage = value;
        return this;
    }
    
    public string ToLetterGrade()
    {
        foreach (var kvp in _averageLetterGrade)
        {
            if (_percentage <=  kvp.Value )
            {
                return kvp.Key;
            }
        }
        return "";
    }

    public float ToPercentage()
    {
        return _percentage;
    }
}