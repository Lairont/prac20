using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// класс проекта строения
    /// </summary>
    internal class Build
    {
        /// <summary>
        /// поле названия строения
        /// </summary>
        public string name;
        /// <summary>
        /// поле площади
        /// </summary>
        public double area;
        /// <summary>
        /// поле количества жильцов
        /// </summary>
        public int kvo;
        /// <summary>
        /// поле количества этажей
        /// </summary>
        public int floor;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Build() 
        { }
        /// <summary>
        /// конструктор с одним параметром 
        /// </summary>
        /// <param name="name"></param>
        public Build(string name)
        {
            this.name = name; 
        }
        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        public Build(string name, double area) : this(name)
        {
            this.area = area;
        }
        /// <summary>
        /// конструктор с тремя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>
        public Build(string name, double area, int kvo) : this(name, area)
        {
            this.kvo = kvo;
        }
        /// <summary>
        /// конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>
        /// <param name="floor"></param>
        public Build(string name, double area, int kvo, int floor): this(name, area, kvo)
        {
            this.floor = floor;
        }
        /// <summary>
        /// метод, который выводит информацию о строении 
        /// и вычисляет площадь на одного жильца
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"В доме {name} площадью {area} кв. метров живет {kvo} человек," +
                $" на человека - {area / kvo:f2} кв. метров");
        }
    }
}
