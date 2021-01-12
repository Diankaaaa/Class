using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите действительную часть числа: ");
            double real = double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть числа: ");
            double im = double.Parse(Console.ReadLine());
            Complex_number a = new Complex_number(real, im);
            a.Print();
            
        }
    }
}
