// Program.cs
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo culture = CultureInfo.CurrentCulture;
        CultureInfo uiCulture = CultureInfo.CurrentUICulture;
        string languageCode = culture.TwoLetterISOLanguageName;

        string userInput;
        string operador;
        float n1;
        float n2;

        // Perguntas baseadas na cultura
        switch (languageCode)
        {
            case "pt":
                Console.WriteLine("Língua atual da interface do usuário: " + uiCulture.TwoLetterISOLanguageName);
                break;
            case "de":
                Console.WriteLine("Aktuelle Benutzeroberflächensprache: " + uiCulture.TwoLetterISOLanguageName);
                break;
            case "it":
                Console.WriteLine("Lingua attuale dell'interfaccia utente: " + uiCulture.TwoLetterISOLanguageName);
                break;
            case "en":
                Console.WriteLine("Current UI language: " + uiCulture.TwoLetterISOLanguageName);
                break;
            default:
                Console.WriteLine("Language not supported.");
                return;
        }

        // Perguntar pelo primeiro número
        Console.WriteLine(GetMessageForFirstNumber(languageCode));
        userInput = Console.ReadLine();
        while (!Validator.IsValidNumber(userInput))
        {
            Console.WriteLine(GetMessageForInvalidInput(languageCode));
            userInput = Console.ReadLine();
        }
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

        // Perguntar pelo segundo número
        Console.WriteLine(GetMessageForSecondNumber(languageCode));
        userInput = Console.ReadLine();
        while (!Validator.IsValidNumber(userInput))
        {
            Console.WriteLine(GetMessageForInvalidInput(languageCode));
            userInput = Console.ReadLine();
        }
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);

        // Perguntar pelo operador
        Console.WriteLine(GetMessageForOperator(languageCode));
        operador = Console.ReadLine();
        while (!Validator.IsValidOperator(operador))
        {
            Console.WriteLine(GetMessageForInvalidOperator(languageCode));
            operador = Console.ReadLine();
        }

        // Realizar o cálculo
        var calculator = new Calculator();
        float total = calculator.PerformCalculation(n1, n2, operador);
        Console.WriteLine(GetMessageForResult(languageCode, n1, operador, n2, total));
    }

    static string GetMessageForFirstNumber(string languageCode)
    {
        return languageCode switch
        {
            "pt" => "Escolha o primeiro número:",
            "de" => "Wählen Sie die erste Zahl:",
            "it" => "Scegli il primo numero:",
            "en" => "Choose the first number:",
            _ => "Invalid language"
        };
    }

    static string GetMessageForSecondNumber(string languageCode)
    {
        return languageCode switch
        {
            "pt" => "Escolha o segundo número:",
            "de" => "Wählen Sie die zweite Zahl:",
            "it" => "Scegli il secondo numero:",
            "en" => "Choose the second number:",
            _ => "Invalid language"
        };
    }

    static string GetMessageForOperator(string languageCode)
    {
        return languageCode switch
        {
            "pt" => "Digite * para Multiplicação, / para Divisão, + para Soma, - para Subtração:",
            "de" => "Geben Sie * für Multiplikation, / für Division, + für Addition, - für Subtraktion ein:",
            "it" => "Inserisci * per Moltiplicazione, / per Divisione, + per Somma, - per Sottrazione:",
            "en" => "Enter * for Multiplication, / for Division, + for Addition, - for Subtraction:",
            _ => "Invalid language"
        };
    }

    static string GetMessageForInvalidInput(string languageCode)
    {
        return languageCode switch
        {
            "pt" => "Entrada inválida. Por favor, insira apenas números.",
            "de" => "Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.",
            "it" => "Input non valido. Per favore, inserisci solo numeri.",
            "en" => "Invalid input. Please enter only numbers.",
            _ => "Invalid language"
        };
    }

    static string GetMessageForInvalidOperator(string languageCode)
    {
        return languageCode switch
        {
            "pt" => "Operador inválido. Por favor, insira um dos seguintes operadores: *, /, +, -",
            "de" => "Ungültiger Operator. Bitte geben Sie einen der folgenden Operatoren ein: *, /, +, -",
            "it" => "Operatore non valido. Per favore, inserisci uno dei seguenti operatori: *, /, +, -",
            "en" => "Invalid operator. Please enter one of the following operators: *, /, +, -",
            _ => "Invalid language"
        };
    }

    static string GetMessageForResult(string languageCode, float n1, string operador, float n2, float total)
    {
        return languageCode switch
        {
            "pt" => $"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}",
            "de" => $"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}",
            "it" => $"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}",
            "en" => $"The result of {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}",
            _ => "Invalid language"
        };
    }
}
