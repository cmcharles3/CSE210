using System;

namespace Fractions
{
    class Fraction
    {
        private int top;
        private int bottom;

        public Fraction()
        {
            top = 1;
            bottom = 1;
        }

        public Fraction(int top)
        {
            this.top = top;
            bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            this.top = top;
            this.bottom = bottom == 0 ? 1 : bottom;
        }

        public void SetTop(int top)
        {
            this.top = top;
        }

        public int GetTop()
        {
            return top;
        }

        public void SetBottom(int bottom)
        {
            this.bottom = bottom == 0 ? 1 : bottom;
        }

        public int GetBottom()
        {
            return bottom;
        }

        public string GetFractionString()
        {
            return $"{top}/{bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)top / bottom;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ---- Verify all three constructors ----
            Fraction fraction1 = new Fraction();          // 1/1
            Fraction fraction2 = new Fraction(6);         // 6/1
            Fraction fraction3 = new Fraction(6, 7);      // 6/7

            Console.WriteLine("Constructors verified:");
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine();

            // ---- Verify getters and setters ----
            Fraction fraction4 = new Fraction();
            fraction4.SetTop(3);
            fraction4.SetBottom(4);

            Console.WriteLine("Getters/Setters verified:");
            Console.WriteLine($"Top: {fraction4.GetTop()}");
            Console.WriteLine($"Bottom: {fraction4.GetBottom()}");
            Console.WriteLine();

            // ---- Verify representations (matching sample output) ----
            Fraction f1 = new Fraction();        // 1/1
            Fraction f2 = new Fraction(5);       // 5/1
            Fraction f3 = new Fraction(3, 4);    // 3/4
            Fraction f4 = new Fraction(1, 3);    // 1/3

            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());
        }
    }
}