using System;

public static class Helper
{
    public static string GetValidNumberInput()
    {
        string userInput;
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));
        return userInput;
    }

    public static string GetValidOperator()
    {
        string operador;
        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Operador inválido. Por favor, insira um dos seguintes operadores: *, /, +, -");
            }
        } while (!IsValidOperator(operador));
        return operador;
    }

    private static bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!Char.IsDigit(c))
                return false;
        }
        return true;
    }

    private static bool IsValidOperator(string s)
    {
        return s == "*" || s == "/" || s == "+" || s == "-";
    }
}
