using System;

namespace bm
{
        class class1
        {
                static void Main(string[] args) 
                {
                        Console.WriteLine("Enter first number: ");
                        string num1in = Console.ReadLine();
                        Console.WriteLine("Enter second number: ");
                        string num2in = Console.ReadLine();
                        double num1 = Convert.ToDouble(num1in);
                        double num2 = Convert.ToDouble(num2in);

                        Console.WriteLine("\n 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n");
                        Console.WriteLine("Basic arithmatic operation: ");
                        string operationin = Console.ReadLine();
                        int operation = Convert.ToInt16(operationin);

                        switch (operation)
                        {
                                case 1:
                                        Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                                        break;
                                case 2:
                                        Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                                        break;
                                case 3:
                                        Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                                        break;
                                case 4:
                                        Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                                        break;
                                default:
                                        Console.WriteLine("Invalid input");
                                        break;
                        }
                }
        }
}
