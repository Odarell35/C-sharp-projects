using System;
public class Program
{
    public static void Main(string[] args)

    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Hello, Welcome to Simple Calculator!\n");
        Console.WriteLine("---------------------------------------------");
        CalcMethods calculation = new CalcMethods();
        double number1, number2, Result;
            

        while(true)
        { 
            Console.WriteLine("Choose operation\n1. Addition\n2.Subtraction\n3. Multiplication\n4.Division\n5.Exit");
            int operationz = Convert.ToInt32(Console.ReadLine());


            switch (operationz)
            {
                case 1:
                    Console.WriteLine("**You have choosen Addition**");
                    Console.WriteLine("Enter first number");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    
                    Result = calculation.Addition(number1 , number2);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Answer: {number1} +  {number2} = " + Result);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("You have choosen Subtraction");
                    Console.WriteLine("Enter first number");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    
                    Result = calculation.Subtraction(number1 , number2);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Answer: {number1} -  {number2} = " + Result);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("You have choosen Multiplication");
                    Console.WriteLine("Enter first number");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    Result = calculation.Multiplication(number1 , number2);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Answer: {number1} *  {number2} = " + Result);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("You have choosen Division");
                    Console.WriteLine("Enter first number");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        Result = calculation.Division(number1, number2);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"Answer: {number1} /  {number2} = " + Result);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("---------------------------------------------");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("*****Good-bye*****");
                    Console.WriteLine("---------------------------------------------");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("Invalid selection");
                    Console.WriteLine("*****************************************");
                    break;


            }

        }

            




    }
}

