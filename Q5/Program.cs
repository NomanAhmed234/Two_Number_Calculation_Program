/*Write code which creates a class Calculation and declare methods like Add() and Subtract(). Take two private variables a abnd b and take user input for these variables that would later be passed to the appropriate method for calculations*/

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter Number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Calculation cal = new Calculation();
            cal._a = num1;
            cal._b = num2;
            cal.Add();
            cal.Subtract();
            cal.Divide();
            cal.Multiply();
        }
    }
}