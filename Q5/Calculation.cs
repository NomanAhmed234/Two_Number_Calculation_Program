using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Calculation
    {
        private double a,b;

        public double _a
        {
            set { a = value; }
            get { return a; }
        } 
        
        public double _b
        {
            set { b = value; }
            get { return b; }
        }
        public void Add()
        {
            Console.WriteLine("Sum = {0}",a+b);
        }

        public void Subtract()
        {
            Console.WriteLine("Difference = {0}", a - b);
        }

        public void Divide()
        {
            Console.WriteLine("Quotient = {0}", a / b);
        }

        public void Multiply()
        {
            Console.WriteLine("Product = {0}", a * b);
        }
    }
}
