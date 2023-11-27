using System;

    // Step 1: Create a delegate
delegate int ArithmeticOperation(int a, int b);

class Program
{
    // Step 2: Implement four static methods
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }
    static void Main()
    {
        // Step 3: Create instances of the 'ArithmeticOperation' delegate
        ArithmeticOperation addOperation = Add;
        ArithmeticOperation subtractOperation = Subtract;
        ArithmeticOperation multiplyOperation = Multiply;
        ArithmeticOperation divideOperation = Divide;

        // Step 4: Ask the user to input two integers
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Step 5: Prompt the user to choose an arithmetic operation
        Console.WriteLine("Choose an arithmetic operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        // Step 6: Based on the user's choice, call the corresponding method through the delegate and display the result
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (choice)
        {
            case 1:
                result = addOperation(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result = subtractOperation(num1, num2);
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = multiplyOperation(num1, num2);
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                result = divideOperation(num1, num2);
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

