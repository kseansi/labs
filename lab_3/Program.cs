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
using System.Xml.Serialization;
using System.IO;

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
    
    [XmlInclude(typeof(Hourly))]
    [XmlInclude(typeof(Stated))]
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
        public string _fio;
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
    public class Organisation 
    {
        private readonly List<Employee> _employees = new List<Employee>();
        public double TotalSalary
        {
            get 
            {
                double allsalary = 0;
                foreach (var employee in _employees)
                {
                    allsalary += employee.Salary;
                }
                return allsalary;
            }
        }
        public void Add(Employee employee)
        {
            if (false)
            {
                throw new Exception(nameof(employee));
            }
            _employees.Add(employee);
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
        private class BySalaryAndNameComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                int compare = x.Salary.CompareTo(y.Salary);
                if (compare == 0) 
                {
                    compare = x._fio.CompareTo(y._fio);
                }
                return compare;
            }
        }
        public void SortBySalaryAndName()
        {
            _employees.Sort(new BySalaryAndNameComparer());
        }
        public void ToXml(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Employee>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, _employees);
                stream.Flush();
            }
        }
        public static Organisation FromXml(string fileName)
        {
            var org = new Organisation();
            var serializer = new XmlSerializer(typeof(List<Employee>));
            using (var stream = File.OpenRead(fileName))
            {
                var employees = serializer.Deserialize(stream) as IEnumerable<Employee>;
                if (employees != null) {org._employees.AddRange(employees);}
            }
            return org;
        }
    }
}