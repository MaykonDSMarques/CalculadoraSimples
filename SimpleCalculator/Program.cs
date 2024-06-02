using System;
using System.Globalization;

CultureInfo culture = CultureInfo.CurrentCulture;

CultureInfo uiCulture = CultureInfo.CurrentUICulture;

string userInput;
string userInput2;
float n1;
float n2;
string operador;

switch (culture.TwoLetterISOLanguageName)
{
    case "pt":
        Console.WriteLine("Língua atual da interface do usuário: " + uiCulture.TwoLetterISOLanguageName);

        Console.WriteLine("Escolha o primeiro número");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Primeiro Número: " + userInput);
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n1} é um número válido.");

        // Solicitar e validar o segundo número
        Console.WriteLine("Escolha o segundo número");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Segundo Número: " + userInput);
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n2} é um número válido.");

        // Solicitar e validar o operador
        Console.WriteLine("Digite * para Multiplicação");
        Console.WriteLine("Digite / para Divisão");
        Console.WriteLine("Digite + para Soma");
        Console.WriteLine("Digite - para Subtração");

        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Operador inválido. Por favor, insira um dos seguintes operadores: *, /, +, -");
            }
        } while (!IsValidOperator(operador));

        Console.WriteLine($"Operador selecionado: {operador}");

        // Realizar a operação com base no operador selecionado
        if (operador == "*")
        {
            Console.WriteLine("Equação selecionada: Multiplicação");
            float total = n1 * n2;
            Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "/")
        {
            Console.WriteLine("Equação selecionada: Divisão");
            float total = n1 / n2;
            Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "+")
        {
            Console.WriteLine("Equação selecionada: Adição");
            float total = n1 + n2;
            Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "-")
        {
            Console.WriteLine("Equação selecionada: Subtração");
            float total = n1 - n2;
            Console.WriteLine($"O resultado de {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} é igual a: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        break;
        
    case "en":
        Console.WriteLine("Choose the first number");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("First Number: " + userInput);
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n1} is a valid number.");

        // Prompt and validate the second number
        Console.WriteLine("Choose the second number");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Second Number: " + userInput);
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n2} is a valid number.");

        // Prompt and validate the operator
        Console.WriteLine("Enter * for Multiplication");
        Console.WriteLine("Enter / for Division");
        Console.WriteLine("Enter + for Addition");
        Console.WriteLine("Enter - for Subtraction");

        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Invalid operator. Please enter one of the following operators: *, /, +, -");
            }
        } while (!IsValidOperator(operador));

        Console.WriteLine($"Selected operator: {operador}");

        // Perform the operation based on the selected operator
        if (operador == "*")
        {
            Console.WriteLine("Selected equation: Multiplication");
            float total = n1 * n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "/")
        {
            Console.WriteLine("Selected equation: Division");
            float total = n1 / n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "+")
        {
            Console.WriteLine("Selected equation: Addition");
            float total = n1 + n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "-")
        {
            Console.WriteLine("Selected equation: Subtraction");
            float total = n1 - n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }

        break;

    case "de":
        Console.WriteLine("Wählen Sie die erste Nummer");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Erste Nummer: " + userInput);
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n1} ist eine gültige Zahl.");

        // Zweite Zahl eingeben und validieren
        Console.WriteLine("Wählen Sie die zweite Nummer");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Zweite Nummer: " + userInput);
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n2} ist eine gültige Zahl.");

        // Operator eingeben und validieren
        Console.WriteLine("Geben Sie * für Multiplikation ein");
        Console.WriteLine("Geben Sie / für Division ein");
        Console.WriteLine("Geben Sie + für Addition ein");
        Console.WriteLine("Geben Sie - für Subtraktion ein");

        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Ungültiger Operator. Bitte geben Sie einen der folgenden Operatoren ein: *, /, +, -");
            }
        } while (!IsValidOperator(operador));

        Console.WriteLine($"Ausgewählter Operator: {operador}");

        // Operation basierend auf dem ausgewählten Operator ausführen
        if (operador == "*")
        {
            Console.WriteLine("Ausgewählte Gleichung: Multiplikation");
            float total = n1 * n2;
            Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "/")
        {
            Console.WriteLine("Ausgewählte Gleichung: Division");
            float total = n1 / n2;
            Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "+")
        {
            Console.WriteLine("Ausgewählte Gleichung: Addition");
            float total = n1 + n2;
            Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "-")
        {
            Console.WriteLine("Ausgewählte Gleichung: Subtraktion");
            float total = n1 - n2;
            Console.WriteLine($"Das Ergebnis von {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} ist: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        break;

    case "it":
        Console.WriteLine("Scegli il primo numero");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Input non valido. Si prega di inserire solo numeri.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Primo numero: " + userInput);
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n1} è un numero valido.");

        // Inserisci e valida il secondo numero
        Console.WriteLine("Scegli il secondo numero");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Input non valido. Si prega di inserire solo numeri.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Secondo numero: " + userInput);
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n2} è un numero valido.");

        // Inserisci e valida l'operatore
        Console.WriteLine("Inserisci * per Moltiplicazione");
        Console.WriteLine("Inserisci / per Divisione");
        Console.WriteLine("Inserisci + per Addizione");
        Console.WriteLine("Inserisci - per Sottrazione");

        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Operatore non valido. Si prega di inserire uno dei seguenti operatori: *, /, +, -");
            }
        } while (!IsValidOperator(operador));

        Console.WriteLine($"Operatore selezionato: {operador}");

        // Esegui l'operazione basata sull'operatore selezionato
        if (operador == "*")
        {
            Console.WriteLine("Equazione selezionata: Moltiplicazione");
            float total = n1 * n2;
            Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "/")
        {
            Console.WriteLine("Equazione selezionata: Divisione");
            float total = n1 / n2;
            Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "+")
        {
            Console.WriteLine("Equazione selezionata: Addizione");
            float total = n1 + n2;
            Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "-")
        {
            Console.WriteLine("Equazione selezionata: Sottrazione");
            float total = n1 - n2;
            Console.WriteLine($"Il risultato di {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} è: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        break;

    default:
        Console.WriteLine("Choose the first number");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("First Number: " + userInput);
        n1 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n1} is a valid number.");

        // Prompt and validate the second number
        Console.WriteLine("Choose the second number");
        do
        {
            userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
        } while (string.IsNullOrEmpty(userInput) || !IsAllDigits(userInput));

        Console.WriteLine("Second Number: " + userInput);
        n2 = float.Parse(userInput, CultureInfo.InvariantCulture);
        Console.WriteLine($"{n2} is a valid number.");

        // Prompt and validate the operator
        Console.WriteLine("Enter * for Multiplication");
        Console.WriteLine("Enter / for Division");
        Console.WriteLine("Enter + for Addition");
        Console.WriteLine("Enter - for Subtraction");

        do
        {
            operador = Console.ReadLine();
            if (!IsValidOperator(operador))
            {
                Console.WriteLine("Invalid operator. Please enter one of the following operators: *, /, +, -");
            }
        } while (!IsValidOperator(operador));

        Console.WriteLine($"Selected operator: {operador}");

        // Perform the operation based on the selected operator
        if (operador == "*")
        {
            Console.WriteLine("Selected equation: Multiplication");
            float total = n1 * n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} * {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "/")
        {
            Console.WriteLine("Selected equation: Division");
            float total = n1 / n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} / {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "+")
        {
            Console.WriteLine("Selected equation: Addition");
            float total = n1 + n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} + {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        else if (operador == "-")
        {
            Console.WriteLine("Selected equation: Subtraction");
            float total = n1 - n2;
            Console.WriteLine($"The result of {n1.ToString(CultureInfo.InvariantCulture)} - {n2.ToString(CultureInfo.InvariantCulture)} is: {total.ToString(CultureInfo.InvariantCulture)}");
        }
        break;

    static bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!Char.IsDigit(c))
                return false;
        }
        return true;
    }

    // Método para verificar se o operador é válido
    static bool IsValidOperator(string s)
    {
        return s == "*" || s == "/" || s == "+" || s == "-";
    }

}

