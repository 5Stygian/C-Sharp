using System;

namespace bm {
        class class1 {
                static void Main(string[] args) {       
                        static void input() {
                                Console.Write("Enter first number: ");
                                string num1in = Console.ReadLine();
                                Console.Write("Enter second number: ");
                                string num2in = Console.ReadLine();
                                double num1 = Convert.ToDouble(num1in);
				double num2 = Convert.ToDouble(num2in);

				Console.WriteLine("\n 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n");
                                Console.Write("Basic arithmatic operation: ");
                                string operation_in = Console.ReadLine();
                                int operation = sbyte.Parse(operation_in);

				switch (operation) {
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
						Console.WriteLine("Invalid operation");
						input(); // recursive function call that would make NASA's guidelines cry 
						break;
				}
			}

			// call input function
			input();
		}
        }
}
