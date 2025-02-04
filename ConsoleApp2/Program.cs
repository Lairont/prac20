using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// основной метод кода
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.ShowInfo();
            Console.WriteLine();
            dom1.name = "Дача";
            dom1.area =600.3;
            dom1.kvo = 3;
            dom1.ShowInfo();
            Console.WriteLine();
            Build dom2 = new Build();
            dom2.name = "Отель";
            dom2.area = 6000.3;
            dom2.kvo = 13450;
            dom2.ShowInfo();
            Console.WriteLine();
            Console.Write("Название строения: ");
            string name=Console.ReadLine();
            Console.Write("Площадь строения: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей:");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(name, area, kvo, floor);
            dom3.ShowInfo();
            Console.Read();


        }
    }
}
