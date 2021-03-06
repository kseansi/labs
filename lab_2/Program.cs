﻿using System;
/*Вариант 1
Составить описание класса для представления комплексных чисел. Обеспечить выполнение
операций сложения, вычитания и умножения комплексного числа на вещественное число.
Предусмотреть поддержку числа в алгебраической форме. Все операции реализовать в виде
перегрузки операторов. Программа должна содержать меню, позволяющее осуществлять
проверку всех методов.*/
namespace lab_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1. Операции с одним к.ч.");
            Console.WriteLine("2. Операции с двумя к.ч.");
            int tmp1 = int.Parse(Console.ReadLine());
            if (tmp1 == 1)
            {//действия с одним комплексным числом (умножение на вещественное число)
                Console.WriteLine("Введите real часть числа");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите imaginary часть числа");
                double i = double.Parse(Console.ReadLine());
                ComplexNumber complex = new ComplexNumber 
                {
                real = r,
                imaginary = i
                };
                Console.WriteLine("Введите множитель");
                double factor = double.Parse(Console.ReadLine());
                complex *= factor;
                Console.WriteLine("z = "+complex.real+" + i*("+complex.imaginary+")");
            }
            else
            {//действия с двумя комплаксными числами (сложение и вычитание)
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                int tmp2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите real часть 1 числа");
                double r1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите imaginary часть 1 числа");
                double i1 = double.Parse(Console.ReadLine());
                ComplexNumber complex1 = new ComplexNumber 
                {
                real = r1,
                imaginary = i1
                };
                Console.WriteLine("Введите real часть 2 числа");
                double r2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите imaginary часть 2 числа");
                double i2 = double.Parse(Console.ReadLine());
                ComplexNumber complex2 = new ComplexNumber 
                {
                real = r2,
                imaginary = i2
                };                
                if (tmp2 == 1)
                {//сложение
                    complex1 += complex2;
                    Console.WriteLine("z = "+complex1.real+" + i*("+complex1.imaginary+")");
                }
                else
                {//вычитание
                    complex1-=complex2;
                    Console.WriteLine("z = "+complex1.real+" + i*("+complex1.imaginary+")");
                }
            }
        }
    }
    class ComplexNumber
    {
        public double real;
        public double imaginary;
        public static ComplexNumber operator + (ComplexNumber comNum1, ComplexNumber comNum2)
        {
            ComplexNumber CN = new ComplexNumber
            {
                real = comNum1.real+comNum2.real,
                imaginary = comNum1.imaginary+comNum2.imaginary
            };
            return CN;  
        }
        public static ComplexNumber operator - (ComplexNumber comNum1, ComplexNumber comNum2)
        {
            ComplexNumber CN = new ComplexNumber
            {
                real = comNum1.real-comNum2.real,
                imaginary = comNum1.imaginary-comNum2.imaginary
            };
            return CN;  
        }
        public static ComplexNumber operator * (ComplexNumber comNum, double num)
        {
            ComplexNumber CN = new ComplexNumber
            {
                real = comNum.real*num,
                imaginary = comNum.imaginary*num
            };
            return CN;
        }
    } 
}