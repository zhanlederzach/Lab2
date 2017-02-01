using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Complex
    {
        int a;
        int b;
        //конструктор для комплексных чисел
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        //метод сложения 
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex(0, 0);
            //сложение действительных частей
            res.a = c1.a + c2.a;
            //сложение мнимых частей
            res.b = c1.b + c2.b;

            return res;
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 3);
            Console.WriteLine(c);
        }
    }
}