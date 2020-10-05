using System;

namespace lab_1
{
    class Program
    {   
        public static void Run()
        { 
            Console.WriteLine("Здравствуйте и добро пожаловать! \n Введите номер желаемых операций: \n 1. Создание фигуры и работа с ней \n 2. Проверка наложения 2 фигур \n 3. ВЫХОД");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1) 
            {
                var figure = Creating();
                Console.WriteLine("Выберите дальнейшие действия: \n 1. Изменение размера \n 2. Поворт \n 3. Перемещение \n 4. ВЫХОД");
                int num3 = int.Parse(Console.ReadLine());
                if (num3 == 1)
                {
                    Console.WriteLine(figure.GetType());
                }
                else if (num3 == 2)
                {
                    Environment.Exit(0);
                }
                else if (num3 == 3)
                {
                    Environment.Exit(0);
                }
                else {Environment.Exit(0);}
            }
           /* else if (num1 == 2) 
            {
                Overlay();
            } */
            else 
            {Environment.Exit(0);}
        }      
        public static object Creating()
        {
            Console.WriteLine("Введите цифру, соответствующую тому, какую фигуру нужно создать: \n 1. Круг \n 2. Прямоугольник \n 3. Квадрат");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 1) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые: радиус, координату х центра, координату у центра");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Circle newFigure = new Circle(); 
                newFigure.radius = a;
                newFigure.xCenter = b;
                newFigure.yCenter = c;
                return newFigure;
            }
            else if (num2 == 2) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Rectangle newFigure = new Rectangle();
                newFigure.x1 = a; newFigure.x2 = b; newFigure.x3 = c; newFigure.x4 = d;
                newFigure.y1 = e; newFigure.y2 = f; newFigure.y3 = g; newFigure.y4 = h;
                return newFigure;

            }
            else 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Square newFigure = new Square();
                newFigure.x1 = a; newFigure.x2 = b; newFigure.x3 = c; newFigure.x4 = d;
                newFigure.y1 = e; newFigure.y2 = f; newFigure.y3 = g; newFigure.y4 = h;
                return newFigure;
            }
        }
        public static void Rotation()
        {

        }
        public static void Moving(out int movingRight, out int movingUp)
        {
            Console.WriteLine("Вы выбрали перемещение фигуры. \n Пожалуйста, введите, на сколько нужно передвинуть фигуру вправо. \n Если фигуру нужно передвинуть влево, введте число со знаком минус.");
            movingRight = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вверх. \n Если фигуру нужно передвинуть вниз, введте число со знаком минус.");        
            movingUp = int.Parse(Console.ReadLine());
        }
        public static void ChangingSize()
        {

        }
        public static void Overlay()
        {
            Console.WriteLine("Вы выбрали наложение двух фигур. \n Пожалуйста, создайте две фигуры.");
            var figure1 = Creating();
            var figure2 = Creating();

        }
        public static void Main(string[] args)
        {
            Run();
        } 
    }
    class Circle
    {
        public int radius;
        public int xCenter;
        public int yCenter;
        //public static void Moving(){}
    }
    class Rectangle
    {
        public int x1; public int x2; public int x3; public int x4;
        public int y1; public int y2; public int y3; public int y4;
       /* public static void Creating(){}
        public static void Rotation(){}
        public static void Moving(){} */
    }
    class Square
    {
        public int x1; public int x2; public int x3; public int x4;
        public int y1; public int y2; public int y3; public int y4;
      /*  public static void Creating(){}
        public static void Rotation(){}
        public static void Moving(){} */
    }
}