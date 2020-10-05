using System;

namespace lab_1
{
    class Program
    {   
        public static void Creating()
        {
            Console.WriteLine("Введите цифру, соответствующую тому, какую фигуру нужно создать: \n 1. Круг \n 2. Прямоугольник \n 3. Квадрат");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 1) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые: радиус, координату х центра, координату у центра");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Circle newCircle = new Circle();
                newCircle.radius = a;
                newCircle.xCenter = b;
                newCircle.yCenter = c;
            }
            else if (num2 == 2) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Rectangle newRectangle = new Rectangle();
                newRectangle.x1 = a; newRectangle.x2 = b; newRectangle.x3 = c; newRectangle.x4 = d;
                newRectangle.y1 = e; newRectangle.y2 = f; newRectangle.y3 = g; newRectangle.y4 = h;

            }
            else 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Square newSquare = new Square();
                newSquare.x1 = a; newSquare.x2 = b; newSquare.x3 = c; newSquare.x4 = d;
                newSquare.y1 = e; newSquare.y2 = f; newSquare.y3 = g; newSquare.y4 = h;
            }
        }
        public static void Run()
        { 
            Console.WriteLine("Здравствуйте и добро пожаловать! \n Введите номер желаемых операций: \n 1. Создание фигуры и работа с ней \n 2. Проверка наложения 2 фигур \n 3. ВЫХОД");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1) 
            {
                Creating();
            }
            /*
            else if (num1 == 2) 
            {
                Overlay();
            }
            else 
            {
                Environment.Exit(0);
            }
            */
        }
        //определение факта наложения двух выбранных фигур
        /*
        public static void Overlay()
        {
            Creating();
            Creating();

        }
        */
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