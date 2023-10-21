using Calculator.App.Services.Interface;

namespace Calculator.App.Services
{

    public class CalculatorService : ICalculatorService
    {
        public int Result { get; set; }
        public string Calculate()
        {
            Console.WriteLine("Enter the first value:");
            int.TryParse(Console.ReadLine(), out int Num1);

            Console.WriteLine("Enter the second value:");
            int.TryParse(Console.ReadLine(), out int Num2);

            Console.WriteLine("Enter the operator (+, -, *, /):");
            char.TryParse(Console.ReadLine(), out char operatorCommand);
            Result = 0;
            switch (operatorCommand)
            {
                case '+':
                    Result = Num1 + Num2;
                    break;
                case '-':
                    Result = Num1 - Num2;
                    break;
                case '*':
                    Result = Num1 * Num2;
                    break;
                case '/':
                    Result = Num1 / Num2;
                    break;
                default:
                    Console.WriteLine("Please input a valid operator (+, -, *, /).");
                    break;
            }
            return $"{Num1} {operatorCommand} {Num2} = {Result}";

        }
    }
}
