using ICT3101_Lab2;

namespace ICT3101_Lab2_Specflow.Contexts;

public class CalculatorContext
{
    public Calculator Calculator { get; set; }

    public CalculatorContext()
    {
        Calculator = new Calculator();
    }   
}