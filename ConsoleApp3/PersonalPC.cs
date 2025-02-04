using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PersonalPC
    {
        public string Model;
        public double CPUfrequency;
        public int RAMcapacity;
        public int HDDcapacity;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public PersonalPC()
        {

        }
        /// <summary>
        /// конструктор с одним параметром 
        /// </summary>
        /// <param name="Model"></param>
        public PersonalPC(string Model)
        {
            this.Model = Model;
        }
        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="CPUfrequency"></param>
        public PersonalPC(string Model, double CPUfrequency) : this(Model)
        {
            this.CPUfrequency = CPUfrequency;
        }
        /// <summary>
        /// конструктор с тремя параметрами
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="CPUfrequency"></param>
        /// <param name="RAMcapacity"></param>
        public PersonalPC(string Model, double CPUfrequency, int RAMcapacity) : this(Model, CPUfrequency)
        {
            this.RAMcapacity = RAMcapacity;
        }
        /// <summary>
        /// конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="CPUfrequency"></param>
        /// <param name="RAMcapacity"></param>
        /// <param name="HDDcapacity"></param>
        public PersonalPC(string Model, double CPUfrequency, int RAMcapacity, int HDDcapacity) : this(Model, CPUfrequency, RAMcapacity)
        {
            this.HDDcapacity = HDDcapacity;
        }
        /// <summary>
        /// Метод, котрый выводит информацию о персональном пк 
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Модель: {Model}, Частота процессора: {CPUfrequency} ГГц," +
                $" Обьем ОЗУ: {RAMcapacity} ГБ, Обьем жесткого диска: {HDDcapacity} ГБ");
        }
        public override string ToString()
        {
            return $"Модель: {Model}, Частота процессора: {CPUfrequency} ГГц," +
                $" Обьем ОЗУ: {RAMcapacity} ГБ, Обьем жесткого диска: {HDDcapacity} ГБ";
        }
    }
}
