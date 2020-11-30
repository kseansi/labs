/*Вариант 1
На основе одной из готовых обобщенных (шаблонных) объектных коллекций .NET создать класс
«Организация», включающий сотрудников. Классы сотрудников должны образовывать иерархию
с базовым классом. Сотрудники бывают двух типов: с фиксированной оплатой и почасовики.
Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы. Для
почасовиков формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 *
почасовую ставку», для сотрудников с фиксированной оплатой «среднемесячная заработная плата
= фиксированной месячной оплате», также к зарплате прибавляется фиксированная премия,
размер которой зависит от должности сотрудника. В виде меню программы реализовать
нижеприведенный функционал.
1. Упорядочить всю последовательность сотрудников по убыванию среднемесячного заработка.
При совпадении зарплаты – упорядочивать данные по алфавиту по ФИО. Вывести идентификатор
работника, ФИО, день рождения и среднемесячный заработок для всех элементов списка.
2. Вывести первые 5 имен работников из полученного в пункте 1 списка.
3. Вывести последние 3 идентификатора работников из полученного в пункте 1 списка.
4. В реальном времени (в процессе заполнения списка сотрудников) рассчитывать и
поддерживать в актуальном состоянии среднемесячную заработную плату по организации,
сохранить значение как поле класса «Организация».
5. Организовать запись и чтение всех данных в/из файла. Реализовать поддержку формата файлов
XML.
6. Организовать обработку некорректного формата входного файла. 
с 66 по 104 слайды
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Collections.Specialized;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public enum Position
    {
        Pawn,
        Novice,
        Adept,
        Luminary
    }
    public abstract class Employee 
    {
        private static readonly Dictionary<Position, double> _prizes = new Dictionary<Position, double>
        {
            [Position.Pawn] = 20,
            [Position.Novice] = 300,
            [Position.Adept] = 4000,
            [Position.Luminary] = 50000

        };
        protected Position _type;
        protected double _prize;
        protected int _id;
        protected string _fio;
        protected Employee() {}
        public Employee(int id, string fio, string birthday, Position type)
        {
            _id = id;
            _fio = fio;
            Birthday = birthday;
            Type = type;
        }
        public Position Type
        {
            get {return _type;}
            set 
            {
                _type = value;
                _prize = _prizes[_type];
            }
        }
        public string Birthday {get; set;}
        public abstract double Salary {get;}
    }
    public class Hourly : Employee 
    {
        private const double k = 166.4;
        public Hourly() {}
        public Hourly(int id, string fio, string birthday, Position type, double salary)
        :base(id, fio, birthday, type)
        {
            salary = Salary;
        }
        public int rate {get; set;}
        public override double Salary 
        {
            get {return k*rate + _prize;}
        }
    }
    public class Stated : Employee 
    {
        public Stated() {}
        public Stated(int id, string fio, string birthday, Position type, double salary)
        :base(id, fio, birthday, type) 
        {
            salary = Salary;
        }
        public int rate {get; set;}
        public override double Salary 
        {
            get {return rate+_prize;}
        }
    }  
}
