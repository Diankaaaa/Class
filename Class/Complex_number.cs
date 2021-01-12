using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Complex_number
    {
        private double a1; //Действительная часть
        private double b1; //Мнимая часть

        //Конструктор
        public Complex_number(double real, double imaginary)
        {
            this.a1 = real;
            this.b1 = imaginary;
        }

        //Геттеры
        public double getA1()
        {
            return a1;
        }

        public double getB1()
        {
            return b1;
        }

        //Функция вычисления модуля комплексного числа
        public double ABC()
        {
            return Math.Sqrt(a1 * a1 + b1 * b1);
        }

        //Функция вычисления числа, которое является обратным заданному
        public double getReverseNumberR()
        {
            double d = a1 * a1 + b1 * b1;
            return a1 / d;
        }
        public double getReverseNumberB()
        {
            double d = a1 * a1 + b1 * b1;
            return -b1 / d;
        }

        //Функция вывода
        public void Print()
        {
            Console.WriteLine("\n" +"Модуль числа: " + ABC() + "\n" + "Обратное число: " + getReverseNumberR() + " " + getReverseNumberB() + "\n");
        }
    }

}
