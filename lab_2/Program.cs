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
            {//действия с одним комплексным числом (умножение на вещественное число)
                Console.WriteLine("Введите множитель");
                int factor = int.Parse(Console.ReadLine());
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
    {
        public int real;
        public int imaginary;
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
        public static ComplexNumber operator * (ComplexNumber comNum, int num)
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