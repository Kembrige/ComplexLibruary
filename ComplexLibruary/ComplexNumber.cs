using System;

namespace ComplexLibruary
{
    public class ComplexNumber
    {
        
        private int real;
        private int imaginary;

        public ComplexNumber()

        {
            Console.WriteLine("Введите числитель:");
            real = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель:");
            imaginary = Convert.ToInt32(Console.ReadLine());
        }
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            return new ComplexNumber(this.real + other.real, this.imaginary + other.imaginary);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            int newReal = this.real * other.real - this.imaginary * other.imaginary;
            int newImaginary = this.real * other.imaginary + this.imaginary * other.real;
            return new ComplexNumber(newReal, newImaginary);
        }

        public ComplexNumber Divide(ComplexNumber other)
        {
            int denominator = other.real * other.real + other.imaginary * other.imaginary;
            int newReal = (this.real * other.real + this.imaginary * other.imaginary) / denominator;
            int newImaginary = (this.imaginary * other.real - this.real * other.imaginary) / denominator;
            return new ComplexNumber(newReal, newImaginary);
        }

        public ComplexNumber MultiplyByRational(int rational)
        {
            return new ComplexNumber(this.real * rational, this.imaginary * rational);
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}

