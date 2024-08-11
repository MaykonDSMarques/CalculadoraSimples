// Program.cs
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo culture = CultureInfo.CurrentCulture;
        CultureInfo uiCulture = CultureInfo.CurrentUICulture;

        string userInput;
        string operador;
        float n1;
        float n2;

        // Perguntas baseadas na cultura
        if (culture.TwoLetterISOLanguageName == "pt")
        {
            Console.WriteLine("Língua atual da interface do usuário: " + uiCulture.TwoLetterISOLanguageName);
        }
        else
        {
            Console.WriteLine("Language not supported.");
            return;
        }

        // Perguntar pelo primeiro número
        Console.WriteLine("Escolha o primeiro número:");
        userInput = Console.ReadLine();
        while (!Validator.IsValidNumber(userInput))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
            userInput = Console.ReadLine();
        }
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

        // Perguntar pelo segundo número
        Console.WriteLine("Escolha o segundo número:");
        userInput = Console.ReadLine();
        while (!Validator.IsValidNumber(userInput))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
            userInput = Console.ReadLine();
        }
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);

        // Perguntar pelo operador
        Console.WriteLine("Digite * para Multiplicação, / para Divisão, + para Soma, - para Subtração:");
        operador = Console.ReadLine();
        while (!Validator.IsValidOperator(operador))
        {
            Console.WriteLine("Operador inválido. Por favor, insira um dos seguintes operadores: *, /, +, -");
            operador = Console.ReadLine();
        }

        // Realizar o cálculo
        var calculator = new Calculator();
        float total = calculator.PerformCalculation(n1, n2, operador);
        Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}");
    }
}
