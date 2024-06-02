using System;
using System.Globalization;

CultureInfo culture = CultureInfo.CurrentCulture;

CultureInfo uiCulture = CultureInfo.CurrentUICulture;

if (culture.TwoLetterISOLanguageName == "pt")
{
    Console.WriteLine("Língua atual da interface do usuário: " + uiCulture.TwoLetterISOLanguageName);

    Console.WriteLine("Escolha o primeiro número");
    string userInput = Console.ReadLine();
    Console.WriteLine("Primeiro Número: " + userInput);
    float n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

    Console.WriteLine("Escolha o Segundo número");
    string userInput2 = Console.ReadLine();
    Console.WriteLine("Segundo Número: " + userInput2);
    float n2 = float.Parse(userInput2, CultureInfo.InvariantCulture);

    Console.WriteLine("Digite * para Multiplicação");
    Console.WriteLine("Digite / para Divisão");
    Console.WriteLine("Digite + para Soma");
    Console.WriteLine("Digite - para Subtração");

    string equatiion = Console.ReadLine();

    if (equatiion == "*")
    {
        Console.WriteLine("Equação selecionada: Multiplicação");
        float total = n1 * n2;
        Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} é igual á:  {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equatiion == "/")
    {
        Console.WriteLine("Equação selecionada: Divisão");
        float total = n1 / n2;
        Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} é igual á:  {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equatiion == "+")
    {
        Console.WriteLine("Equação selecionada: Adição");
        float total = n1 + n2;
        Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} é igual á:  {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equatiion == "-")
    {
        Console.WriteLine("Equação selecionada: Subtração");
        float total = n1 - n2;
        Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} é igual á:  {total.ToString(CultureInfo.InvariantCulture)}");
    }
}

if (culture.TwoLetterISOLanguageName == "en")
{
    Console.WriteLine("Current user interface language: " + uiCulture.TwoLetterISOLanguageName);

    Console.WriteLine("Choose the first number");
    string userInput = Console.ReadLine();
    Console.WriteLine("First Number: " + userInput);
    float n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

    Console.WriteLine("Choose the second number");
    string userInput2 = Console.ReadLine();
    Console.WriteLine("Second Number: " + userInput2);
    float n2 = float.Parse(userInput2, CultureInfo.InvariantCulture);

    Console.WriteLine("Type * for Multiplication");
    Console.WriteLine("Type / for Division");
    Console.WriteLine("Type + for Addition");
    Console.WriteLine("Type - for Subtraction");

    string equation = Console.ReadLine();

    if (equation == "*")
    {
        Console.WriteLine("Selected equation: Multiplication");
        float total = n1 * n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "/")
    {
        Console.WriteLine("Selected equation: Division");
        float total = n1 / n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "+")
    {
        Console.WriteLine("Selected equation: Addition");
        float total = n1 + n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "-")
    {
        Console.WriteLine("Selected equation: Subtraction");
        float total = n1 - n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }

}

if (culture.TwoLetterISOLanguageName == "de")
{
    Console.WriteLine("Aktuelle Benutzeroberflächensprache: " + uiCulture.TwoLetterISOLanguageName);

    Console.WriteLine("Wählen Sie die erste Zahl");
    string userInput = Console.ReadLine();
    Console.WriteLine("Erste Zahl: " + userInput);
    float n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

    Console.WriteLine("Wählen Sie die zweite Zahl");
    string userInput2 = Console.ReadLine();
    Console.WriteLine("Zweite Zahl: " + userInput2);
    float n2 = float.Parse(userInput2, CultureInfo.InvariantCulture);

    Console.WriteLine("Geben Sie * für Multiplikation ein");
    Console.WriteLine("Geben Sie / für Division ein");
    Console.WriteLine("Geben Sie + für Addition ein");
    Console.WriteLine("Geben Sie - für Subtraktion ein");

    string equation = Console.ReadLine();

    if (equation == "*")
    {
        Console.WriteLine("Ausgewählte Gleichung: Multiplikation");
        float total = n1 * n2;
        Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "/")
    {
        Console.WriteLine("Ausgewählte Gleichung: Division");
        float total = n1 / n2;
        Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "+")
    {
        Console.WriteLine("Ausgewählte Gleichung: Addition");
        float total = n1 + n2;
        Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "-")
    {
        Console.WriteLine("Ausgewählte Gleichung: Subtraktion");
        float total = n1 - n2;
        Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
    }

}

if (culture.TwoLetterISOLanguageName == "it")
{
    Console.WriteLine("Lingua corrente dell'interfaccia utente: " + uiCulture.TwoLetterISOLanguageName);

    Console.WriteLine("Scegli il primo numero");
    string userInput = Console.ReadLine();
    Console.WriteLine("Primo Numero: " + userInput);
    float n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

    Console.WriteLine("Scegli il secondo numero");
    string userInput2 = Console.ReadLine();
    Console.WriteLine("Secondo Numero: " + userInput2);
    float n2 = float.Parse(userInput2, CultureInfo.InvariantCulture);

    Console.WriteLine("Digita * per la Moltiplicazione");
    Console.WriteLine("Digita / per la Divisione");
    Console.WriteLine("Digita + per l'Addizione");
    Console.WriteLine("Digita - per la Sottrazione");

    string equation = Console.ReadLine();

    if (equation == "*")
    {
        Console.WriteLine("Equazione selezionata: Moltiplicazione");
        float total = n1 * n2;
        Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "/")
    {
        Console.WriteLine("Equazione selezionata: Divisione");
        float total = n1 / n2;
        Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "+")
    {
        Console.WriteLine("Equazione selezionata: Addizione");
        float total = n1 + n2;
        Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "-")
    {
        Console.WriteLine("Equazione selezionata: Sottrazione");
        float total = n1 - n2;
        Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
    }

}

if(culture.TwoLetterISOLanguageName != "pt" || culture.TwoLetterISOLanguageName != "en" || culture.TwoLetterISOLanguageName == "de" || culture.TwoLetterISOLanguageName == "it")
{
    Console.WriteLine("Current user interface language: " + uiCulture.TwoLetterISOLanguageName);

    Console.WriteLine("Choose the first number");
    string userInput = Console.ReadLine();
    Console.WriteLine("First Number: " + userInput);
    float n1 = float.Parse(userInput, CultureInfo.InvariantCulture);

    Console.WriteLine("Choose the second number");
    string userInput2 = Console.ReadLine();
    Console.WriteLine("Second Number: " + userInput2);
    float n2 = float.Parse(userInput2, CultureInfo.InvariantCulture);

    Console.WriteLine("Type * for Multiplication");
    Console.WriteLine("Type / for Division");
    Console.WriteLine("Type + for Addition");
    Console.WriteLine("Type - for Subtraction");

    string equation = Console.ReadLine();

    if (equation == "*")
    {
        Console.WriteLine("Selected equation: Multiplication");
        float total = n1 * n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "/")
    {
        Console.WriteLine("Selected equation: Division");
        float total = n1 / n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "+")
    {
        Console.WriteLine("Selected equation: Addition");
        float total = n1 + n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
    else if (equation == "-")
    {
        Console.WriteLine("Selected equation: Subtraction");
        float total = n1 - n2;
        Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
    }
}