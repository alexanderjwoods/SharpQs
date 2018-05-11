using System;

namespace Calculator
{
    public class Calculations
    {
        public double Add()
        {
            return GetFirstNumber() + GetSecondNumber();
        }

        public double Subtract()
        {
            return GetFirstNumber() - GetSecondNumber();
        }

        public double Multiply()
        {
            return GetFirstNumber() * GetSecondNumber();
        }

        public double Divide()
        {
            return GetFirstNumber() / GetSecondNumber();
        }

        public double Square()
        {
            for(; ; )
            {
                Console.Write("Input number to square: ");
                
                if(Double.TryParse(Console.ReadLine(), out double number))
                {
                    return Math.Sqrt(number);
                }
            }
        }

        public double Power()
        {
            return Math.Pow(GetFirstNumber(), GetSecondNumber());
        }

        private double GetFirstNumber()
        {
            for (; ; )
            {
                Console.Write("Input First Number: ");
                if (Double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
            }
        }

        private double GetSecondNumber()
        {
            for (; ; )
            {
                Console.Write("Input Second Number: ");
                if (Double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
            }
        }
    }
}