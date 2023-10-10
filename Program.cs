// SIMPLE CALCULATOR  APP
Console.Title = "=====Simple Calculator=====";
Console.WriteLine("=====Simple Calculator=====");
double result;
bool flag = true;
try
{
    double firstOperand = 0;
    double secondOperand =  0;
    while(flag)
    {
        Console.WriteLine("Enter: \n1. + or add for Addition\n2. - or subtract for Subtraction\n3. * or multiply for Multiplication\n4. / or divide for Division");
        string operatorInput = Console.ReadLine()!;
        switch(operatorInput.ToLower()!)
        {
            case "+":
            case "add":
            Console.WriteLine("Enter first operand: ");
            firstOperand = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second operand: ");
            secondOperand = double.Parse(Console.ReadLine()!);
            result = firstOperand + secondOperand;
            Console.WriteLine($"{firstOperand} + {secondOperand} = {Math.Round(result, 2)}");
            break;

            case "-":
            case "subtract":
            Console.WriteLine("Enter first operand: ");
            firstOperand = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second operand: ");
            secondOperand = double.Parse(Console.ReadLine()!);
            result = firstOperand  - secondOperand;
            Console.WriteLine($"{firstOperand} - {secondOperand} = {Math.Round(result, 2)}");
            break;

            case "*":
            case "multiply":
            Console.WriteLine("Enter first operand: ");
            firstOperand = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second operand: ");
            secondOperand = double.Parse(Console.ReadLine()!);
            result = firstOperand * secondOperand;
            Console.WriteLine($"{firstOperand} * {secondOperand} = {Math.Round(result, 2)}");
            break;

            case "/":
            case "divide":
            Console.WriteLine("Enter first operand: ");
            firstOperand = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter second operand: ");
            secondOperand = double.Parse(Console.ReadLine()!);
            result = firstOperand / secondOperand;
            if (secondOperand == 0)
            {
                throw new Exception();
            }
            Console.WriteLine($"{firstOperand} / {secondOperand} = {Math.Round(result, 2)}");
            break;
        }
        string option;
        do
        {
            Console.WriteLine("Do you want perform another calculation?(y for yes / n for no)");
            option = Console.ReadLine()!.ToLower();

        }while(!option.Equals("y".ToLower()) && !option.Equals("n".ToLower()));
        flag = option.Equals("y".ToLower());

        if(!flag)
        {
            Console.WriteLine("Thank you for using our calculator application");
        }
    }
}    
catch(Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("An Error Ocurred!");
    Console.ResetColor();
}
