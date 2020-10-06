using System;

namespace lab_94
{
    class Program
    {   
        public static void Main(string[] args)
        {
            Run();
        } 
        public static void Run()
        {
            Console.WriteLine("Здравствуйте и добро пожаловать! \n Введите номер желаемых операций: \n 1. Создание фигуры и работа с ней \n 2. Проверка наложения 2 фигур \n 3. ВЫХОД");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1) 
            {
                int a = Creating();
                if (a == 1)
                {
                    Circle newCircle = new Circle();
                    Console.WriteLine("Введите через ENTER последовательно целые: радиус, координату х центра, координату у центра");
                    int aa = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    Circle newFig = new Circle(); 
                    newFig.radius = a;
                    newFig.xCenter = b;
                    newFig.yCenter = c;
                    newCircle = newFig;
                    Console.WriteLine("Выберите дальнейшие действия: \n 1. Изменение размера \n 2. Поворт \n 3. Перемещение \n 4. ВЫХОД");
                    int num3 = int.Parse(Console.ReadLine());
                    if (num3 == 1)
                    {
                        newCircle.ChangingSize();
                        Console.WriteLine("Новые параметры фигуры: \n x= "+newCircle.xCenter+"\n y= "+newCircle.yCenter+"\n Радиус= "+newCircle.radius);
                    }
                    else if (num3 == 2)
                    {
                        Console.WriteLine("Круг нельзя повернуть.");

                    }
                    else if (num3 == 3)
                    {
                        newCircle.Moving();
                        Console.WriteLine("Новые параметры фигуры: \n x= "+newCircle.xCenter+"\n y= "+newCircle.yCenter+"\n Радиус= "+newCircle.radius);
                    }
                    else {Environment.Exit(0);}

                }
                else if (a == 2)
                {
                    Rectangle newRectangle = new Rectangle();
                    Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                    int aa = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                    int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                    Rectangle newFig = new Rectangle();
                    newFig.x1 = (float)aa; newFig.x2 = (float)b; newFig.x3 = (float)c; newFig.x4 = (float)d;
                    newFig.y1 = (float)e; newFig.y2 = (float)f; newFig.y3 = (float)g; newFig.y4 = (float)h;
                    newRectangle = newFig;
                    Console.WriteLine("Выберите дальнейшие действия: \n 1. Изменение размера \n 2. Поворт \n 3. Перемещение \n 4. ВЫХОД");
                    int num3 = int.Parse(Console.ReadLine());
                    if (num3 == 1)
                    {
                        newRectangle.ChangingSize();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newRectangle.x1+"\nx2= "+newRectangle.x2+"\nx3= "+newRectangle.x3+"\nx4= "+newRectangle.x4+"\ny1= "+newRectangle.y1+"\ny2= "+newRectangle.y2+"\ny3= "+newRectangle.y3+"\ny4= "+newRectangle.y4);
                    }
                    else if (num3 == 2)
                    {
                        newRectangle.Rotation();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newRectangle.x1+"\nx2= "+newRectangle.x2+"\nx3= "+newRectangle.x3+"\nx4= "+newRectangle.x4+"\ny1= "+newRectangle.y1+"\ny2= "+newRectangle.y2+"\ny3= "+newRectangle.y3+"\ny4= "+newRectangle.y4);
                    }
                    else if (num3 == 3)
                    {
                        newRectangle.Moving();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newRectangle.x1+"\nx2= "+newRectangle.x2+"\nx3= "+newRectangle.x3+"\nx4= "+newRectangle.x4+"\ny1= "+newRectangle.y1+"\ny2= "+newRectangle.y2+"\ny3= "+newRectangle.y3+"\ny4= "+newRectangle.y4);
                    }
                    else {Environment.Exit(0);}                    
                }
                else 
                {
                    Square newSquare = new Square();
                    Console.WriteLine("Введите через ENTER последовательно целые координаты: х1, х2, х3, х4, у1, у2, у3, у4");
                    int aa = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); int c = int.Parse(Console.ReadLine()); int d = int.Parse(Console.ReadLine());
                    int e = int.Parse(Console.ReadLine()); int f = int.Parse(Console.ReadLine()); int g = int.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                    Square newFig = new Square();
                    newFig.x1 = (float)aa; newFig.x2 = (float)b; newFig.x3 = (float)c; newFig.x4 = (float)d;
                    newFig.y1 = (float)e; newFig.y2 = (float)f; newFig.y3 = (float)g; newFig.y4 = (float)h;
                    newSquare = newFig;  
                    Console.WriteLine("Выберите дальнейшие действия: \n 1. Изменение размера \n 2. Поворт \n 3. Перемещение \n 4. ВЫХОД");
                    int num3 = int.Parse(Console.ReadLine());
                    if (num3 == 1)
                    {
                        newSquare.ChangingSize();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newSquare.x1+"\nx2= "+newSquare.x2+"\nx3= "+newSquare.x3+"\nx4= "+newSquare.x4+"\ny1= "+newSquare.y1+"\ny2= "+newSquare.y2+"\ny3= "+newSquare.y3+"\ny4= "+newSquare.y4);
                    }
                    else if (num3 == 2)
                    {
                        newSquare.Rotation();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newSquare.x1+"\nx2= "+newSquare.x2+"\nx3= "+newSquare.x3+"\nx4= "+newSquare.x4+"\ny1= "+newSquare.y1+"\ny2= "+newSquare.y2+"\ny3= "+newSquare.y3+"\ny4= "+newSquare.y4);
                    }
                    else if (num3 == 3)
                    {
                        newSquare.Moving();
                        Console.WriteLine("Новые параметры фигуры: \n x1= "+newSquare.x1+"\nx2= "+newSquare.x2+"\nx3= "+newSquare.x3+"\nx4= "+newSquare.x4+"\ny1= "+newSquare.y1+"\ny2= "+newSquare.y2+"\ny3= "+newSquare.y3+"\ny4= "+newSquare.y4);
                    }
                    else {Environment.Exit(0);}                                      
                } 
            }
            else 
            {Environment.Exit(0);}            
        }
        public static int Creating()
        {
            Console.WriteLine("Вы выбрали создание фигуры. \n Введите номер желаемой фигуры: \n 1. Круг \n 2. Прямоугольник \n 3. Квадрат");
            int num1 = int.Parse(Console.ReadLine());
            return num1;
        }      
    }
    abstract class Figure
    {
        public float center { get; set; }
        public abstract void Moving();
        public abstract void Rotation();
        public abstract void ChangingSize();
    }
    class Circle : Figure 
    {
        public int radius;
        public int xCenter;
        public int yCenter;
        public override void Moving()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вправо.");
            int movingRight = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вверх.");        
            int movingUp = int.Parse(Console.ReadLine());
            xCenter += movingRight;
            yCenter += movingUp; 
        }
        public override void Rotation()
        {}
        public override void ChangingSize()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно увеличить фигуру.");
            int resizing = int.Parse(Console.ReadLine());
            radius+=resizing;
        }        
    }
    class Rectangle : Figure 
    {
        public float x1; public float x2; public float x3; public float x4;
        public float y1; public float y2; public float y3; public float y4;
        public float xCenter;
        public float yCenter;
        public override void Moving()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вправо. \n Если фигуру нужно передвинуть влево, введте число со знаком минус.");
            int movingRight = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вверх. \n Если фигуру нужно передвинуть вниз, введте число со знаком минус.");        
            int movingUp = int.Parse(Console.ReadLine());
            x1+=movingRight; x2+=movingRight; x3+=movingRight; x4+=movingRight;
            y1+=movingUp; y2+=movingUp; y3+=movingUp; y4+=movingUp;
            xCenter += movingRight;
            yCenter += movingUp; 
        }
        public override void Rotation()
        {
            Console.WriteLine("Пожалуйста, введите, на какой угол нужно повернуть фигуру вправо.");
            int angleRotation = int.Parse(Console.ReadLine());
        }
        public override void ChangingSize()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно увеличить фигуру.");
            int resizing = int.Parse(Console.ReadLine());
            float resize = resizing/2;
            x1 -= resize; x4 -= resize; y1 -= resize; y4 -= resize;
            x2 += resize; x3 += resize; y2 += resize; y2 += resize;
        }
    }
    class Square : Figure 
    {
        public float x1; public float x2; public float x3; public float x4;
        public float y1; public float y2; public float y3; public float y4; 
        public float xCenter;
        public float yCenter;
        public override void Moving()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вправо. \n Если фигуру нужно передвинуть влево, введте число со знаком минус.");
            int movingRight = int.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите, на сколько нужно передвинуть фигуру вверх. \n Если фигуру нужно передвинуть вниз, введте число со знаком минус.");        
            int movingUp = int.Parse(Console.ReadLine());
            xCenter += movingRight;
            x1+=movingRight; x2+=movingRight; x3+=movingRight; x4+=movingRight;
            y1+=movingUp; y2+=movingUp; y3+=movingUp; y4+=movingUp;
            yCenter += movingUp; 
        }
        public static void FindCenter()
        {

        }
        public override void Rotation()
        {
            Console.WriteLine("Пожалуйста, введите, на какой угол нужно повернуть фигуру вправо.");
            int angleRotation = int.Parse(Console.ReadLine());
        }
        public override void ChangingSize()
        {
            Console.WriteLine("Пожалуйста, введите, на сколько нужно увеличить фигуру.");
            int resizing = int.Parse(Console.ReadLine());
        }
    }
}