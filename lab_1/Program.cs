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
                Console.WriteLine("Введите цифру, соответствующую тому, какую фигуру нужно создать: \n 1. Круг \n 2. Прямоугольник \n 3. Квадрат");
                int num2 = int.Parse(Console.ReadLine());
                Figure fuckingFigure = Creating(num2);
                Console.WriteLine("Выберите дальнейшие действия: \n 1. Изменение размера \n 2. Поворт \n 3. Перемещение \n 4. ВЫХОД");
                int num3 = int.Parse(Console.ReadLine());
                if (num3 == 1)
                {
                    
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
        public static Figure Creating(int num2)
        {
            Circle newCircle = new Circle();
            Rectangle newRectangle = new Rectangle();
            Square newSquare = new Square();             
            if (num2 == 1) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые: радиус, координату х центра, координату у центра");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                Circle newFig = new Circle(); 
                newFig.radius = a;
                newFig.xCenter = b;
                newFig.yCenter = c;
                newFig.figureType = "circle";
                newCircle = newFig;
                return newCircle;
            }
            else if (num2 == 2) 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Rectangle newFig = new Rectangle();
                newFig.x1 = a; newFig.x2 = b; newFig.x3 = c; newFig.x4 = d;
                newFig.y1 = e; newFig.y2 = f; newFig.y3 = g; newFig.y4 = h;
                newFig.figureType = "rectangle";
                newRectangle = newFig;
                return newRectangle;
            }
            else 
            {
                Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                Square newFig = new Square();
                newFig.x1 = a; newFig.x2 = b; newFig.x3 = c; newFig.x4 = d;
                newFig.y1 = e; newFig.y2 = f; newFig.y3 = g; newFig.y4 = h;
                newFig.figureType = "square";
                newSquare = newFig;
                return newSquare;
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
            Creating();
            Creating();

        }
        public static void Main(string[] args)
        {
            Run();
        } 
    }
    public abstract class Figure 
    {
        abstract 
    }
    class Circle : Figure
    {
        public string figureType;
        public int radius;
        public int xCenter;
        public int yCenter;
    }
    class Rectangle  : Figure
    {
        public string figureType;
        public int x1; public int x2; public int x3; public int x4;
        public int y1; public int y2; public int y3; public int y4;
       /* public static void Creating(){}
        public static void Rotation(){}
        public static void Moving(){} */
    }
    class Square : Figure
    {
        public string figureType;
        public int x1; public int x2; public int x3; public int x4;
        public int y1; public int y2; public int y3; public int y4;
      /*  public static void Creating(){}
        public static void Rotation(){}
        public static void Moving(){} */
    }
}
//+5h27m