using Calculator.App.Services.Interface;

namespace Calculator.App.Services
{

    public class CalculatorService : ICalculatorService
    {
        int Result { get; set; }
        public string Calculator()
        {
            while (true)
            {
                Console.WriteLine("Input first value");
                int.TryParse(Console.ReadLine(), out int Num1);

                Console.WriteLine("Input second value");
                int.TryParse(Console.ReadLine(), out int Num2);

                Console.WriteLine("Input operation");
                char.TryParse(Console.ReadLine(), out char OperatorCommand);
                switch (OperatorCommand)
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
                        Console.WriteLine("Please input correct operator");
                        break;

                }
                return $"{Num1} {OperatorCommand} {Num2} = {Result}";


            }


        }
    }
}
