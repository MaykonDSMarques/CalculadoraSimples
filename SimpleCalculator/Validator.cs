// Validator.cs
public static class Validator
{
    public static bool IsValidNumber(string s)
    {
        return float.TryParse(s, out _);
    }

    public static bool IsValidOperator(string s)
    {
        return s == "*" || s == "/" || s == "+" || s == "-";
    }
}
