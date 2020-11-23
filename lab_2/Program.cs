using System;
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
            {//действия с одним комплексным числом (число в алгебраической форме и умножение на вещественное число)
                Console.WriteLine("1. Перевести число в алгебраическую форму");
                Console.WriteLine("2. Умножить к.ч. на вещественное число");
                int tmp2 = int.Parse(Console.ReadLine());
                if (tmp2 == 1)
                {//число в алгебраической форме
                    Console.WriteLine("1. Операции с одним к.ч.");
                    Console.WriteLine("1. Перевести число в алгебраическую форму");
                }
                else
                {//умножение на вещественное число
                    Console.WriteLine("1. Операции с одним к.ч.");
                    Console.WriteLine("2. Умножить к.ч. на вещественное число");
                }
            }
            else
            {//действия с двумя комплаксными числами (сложение и вычитание)
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                int tmp2 = int.Parse(Console.ReadLine());
                if (tmp2 == 1)
                {//сложение
                    Console.WriteLine("2. Операции с двумя к.ч.");
                    Console.WriteLine("1. Сложение");
                }
                else
                {//вычитание
                    Console.WriteLine("2. Операции с двумя к.ч.");
                    Console.WriteLine("2. Вычитание");
                }
            }
        }
    }
    class ComplexNumber
    {/*
        public static ComplexNumber operator + (ComplexNumber comNum1, ComplexNumber comNum2)
        {

        }
        public static ComplexNumber operator - (ComplexNumber comNum1, ComplexNumber comNum2)
        {

        }
        public static ComplexNumber operator * (ComplexNumber comNum, float num)
        {

        }*/
    } 
}