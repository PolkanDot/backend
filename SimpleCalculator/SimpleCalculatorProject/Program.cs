using System;

namespace SimpleCalculator
{
    class Program
    {
        private static double ReadOperand()
        {
            string operandString;
            double operand;

            operandString = Console.ReadLine();

            try
            {
                operand = Convert.ToDouble(operandString);
            }
            catch
            {
                throw new Exception($"'{operandString}' - неверный операнд");
            }
            return operand;
        }
        static void Main(string[] args)
        {
            string operation;
            double operand1;
            double operand2;
            double result;

            try
            { 
                Console.WriteLine("Введите первый операнд: ");
                operand1 = ReadOperand();

                Console.WriteLine("Введите второй операнд: ");
                operand2 = ReadOperand();

                Console.WriteLine("Введите операцию (+, -, *, /): ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        {
                            result = operand1 + operand2;
                            break;
                        }
                    case "-":
                        {
                            result = operand1 - operand2;
                            break;
                        }
                    case "*":
                        {
                            result = operand1 * operand2;
                            break;
                        }
                    case "/":
                        {
                            if (operand2 != 0)
                            {
                                result = operand1 / operand2;
                                break;
                            }
                            else
                            {
                                throw new Exception("Деление на ноль");
                            }
                            
                        }
                    default:
                        {
                            throw new Exception($"Неправильная операция: '{operation}'");
                        }
                }
                Console.WriteLine($"{operand1:0.00} {operation} {operand2:0.00} = {result:0.00}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
