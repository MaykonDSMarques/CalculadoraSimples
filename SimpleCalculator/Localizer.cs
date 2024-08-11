using System;
using System.Globalization;

public class Localizer
{
    public void DisplayInstructions(CultureInfo culture)
    {
        switch (culture.TwoLetterISOLanguageName)
        {
            case "pt":
                Console.WriteLine("Escolha o primeiro número");
                Console.WriteLine("Escolha o segundo número");
                Console.WriteLine("Digite * para Multiplicação");
                Console.WriteLine("Digite / para Divisão");
                Console.WriteLine("Digite + para Soma");
                Console.WriteLine("Digite - para Subtração");
                break;
            case "en":
                Console.WriteLine("Choose the first number");
                Console.WriteLine("Choose the second number");
                Console.WriteLine("Enter * for Multiplication");
                Console.WriteLine("Enter / for Division");
                Console.WriteLine("Enter + for Addition");
                Console.WriteLine("Enter - for Subtraction");
                break;
            case "de":
                Console.WriteLine("Wählen Sie die erste Nummer");
                Console.WriteLine("Wählen Sie die zweite Nummer");
                Console.WriteLine("Geben Sie * für Multiplikation ein");
                Console.WriteLine("Geben Sie / für Division ein");
                Console.WriteLine("Geben Sie + für Addition ein");
                Console.WriteLine("Geben Sie - für Subtraktion ein");
                break;
            case "it":
                Console.WriteLine("Scegli il primo numero");
                Console.WriteLine("Scegli il secondo numero");
                Console.WriteLine("Inserisci * per Moltiplicazione");
                Console.WriteLine("Inserisci / per Divisione");
                Console.WriteLine("Inserisci + per Addizione");
                Console.WriteLine("Inserisci - per Sottrazione");
                break;
            default:
                Console.WriteLine("Choose the first number");
                Console.WriteLine("Choose the second number");
                Console.WriteLine("Enter * for Multiplication");
                Console.WriteLine("Enter / for Division");
                Console.WriteLine("Enter + for Addition");
                Console.WriteLine("Enter - for Subtraction");
                break;
        }
    }

    public void DisplayResult(float n1, float n2, string operador, float result, CultureInfo culture)
    {
        switch (culture.TwoLetterISOLanguageName)
        {
            case "pt":
                Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {result.ToString(CultureInfo.InvariantCulture)}");
                break;
            case "en":
                Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} is: {result.ToString(CultureInfo.InvariantCulture)}");
                break;
            case "de":
                Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} ist: {result.ToString(CultureInfo.InvariantCulture)}");
                break;
            case "it":
                Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} è: {result.ToString(CultureInfo.InvariantCulture)}");
                break;
            default:
                Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} {operador} {n2.ToString(CultureInfo.InvariantCulture)} is: {result.ToString(CultureInfo.InvariantCulture)}");
                break;
        }
    }
}
