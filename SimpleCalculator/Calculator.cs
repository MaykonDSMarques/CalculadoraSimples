// Calculator.cs
public class Calculator
{
    public float PerformCalculation(float n1, float n2, string operador)
    {
        return operador switch
        {
            "*" => n1 * n2,
            "/" => n1 / n2,
            "+" => n1 + n2,
            "-" => n1 - n2,
            _ => throw new InvalidOperationException("Operador inválido"),
        };
    }
}
