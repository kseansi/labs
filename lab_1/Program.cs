using System;

namespace lab_1
{
    class Program
    {
        //создание объекта - круга, квадрата, прямоугольника
        public Creating()
        {
                Console.WriteLine("Выберите тип создаваемой фигуры:");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Квадрат");
                Console.WriteLine("3. Прямоугольник");
                int num2 = int.Parse(Console.ReadLine());
                if (num2 == 1) 
                {
                    Console.WriteLine("Введите через запятую ЦЕЛЫЕ: радиус, координату Х центра окружности, координату Y центра окружности");
                }
                else 
                {
                    Console.WriteLine("Введите через запятую попарно ЦЕЛЫЕ:");
                    Console.WriteLine("Координату Х1, Координату Y1");
                    Console.WriteLine("Координату Х2, Координату Y2");
                    Console.WriteLine("Координату Х3, Координату Y3");
                    Console.WriteLine("Координату Х4, Координату Y4");
                }
                Console.WriteLine("Введите номер желаемой операции:");
                Console.WriteLine("1. Перемещение на плоскости на заданный вектор");
                Console.WriteLine("2. Изменение размера относительно геометрического центра фигуры");
                Console.WriteLine("3. Вращение на заданный угол");
                Console.WriteLine("4. Выход в главное меню");
        }

        //перемещение на плоскости на заданный вектор
        public Moving()
        {

        }

        //изменение размеров относительно ГЦФ
        public ChangingScale()
        {

        }

        //вращение на заданный угол относительно ГЦФ
        public Rotation()
        {

        }

        //определение факта наложения двух выбранных фигур
        public Overlay()
        {

        }
        public static void Run()
        { 
            Console.WriteLine("Здравствуйте и добро пожаловать!");
            Console.WriteLine("Введите номер желаемых операций:");
            Console.WriteLine("1. Создание фигуры и работа с ней");
            Console.WriteLine("2. Проверка наложения 2 фигур");
            Console.WriteLine("3. ВЫХОД");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Creating();                
            }
            else if (num1 == 2)
            {
                Overlay();
            }
            else 
            {
                Environment.Exit(0);
            }
        }   
        public static void Main(string[] args)
        {
            Run();
        }
    }
}
