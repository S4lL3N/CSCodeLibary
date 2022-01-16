/*
 * Module 1 assignment part 2: First Solution
 * @author Shae Allen – CPSC-2710-AO1 
 * @version 1/15/22
 * 
 * 
 * This console application will prompt the user for two numbers and an operation (addition, subtraction,or multiplication).
 * The program will output the result of performing the selected operation on the two numbers to the console.
 */

float answer;
float number1;
float number2;
String operation;

Console.WriteLine("First Console Application\n");

//prompt for instructions
Console.WriteLine("The First solution will preform a calculation (addition(+), subtraction(-),or multiplication(*)).\n");

//get first number
Console.Write("Enter the first number: ");
number1 = float.Parse(Console.ReadLine());

//get operation
Console.Write("Enter the operation: ");
operation = Console.ReadLine();

//get second number
Console.Write("Enter the second number: ");
number2 = float.Parse(Console.ReadLine());

//conditional for operation
if (operation.Equals("+"))
{
    answer = number1 + number2;
}
else if (operation.Equals("-"))
{
    answer = number1 - number2;
}
else
{
    answer = number1 * number2;
}
//output answer
Console.WriteLine(number1 + " " + operation + " " + number2 + " = " + answer);