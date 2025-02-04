using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /// <summary>
        /// основной метод кода
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PersonalPC pc1 = new PersonalPC();
            pc1.Info();
            Console.WriteLine($"{pc1.ToString()}");
            Console.WriteLine();
            PersonalPC pc2 = new PersonalPC("C1");
            pc2.Info();
            Console.WriteLine($"{pc2.ToString()}");
            Console.WriteLine();
            PersonalPC pc3 = new PersonalPC("C1",3.5);
            pc3.Info();
            Console.WriteLine($"{pc3.ToString()}");
            Console.WriteLine();
            PersonalPC pc4 = new PersonalPC("C1",3.5,16);
            pc4.Info();
            Console.WriteLine($"{pc4.ToString()}");
            Console.WriteLine();
            PersonalPC pc5 = new PersonalPC("C1",3.5,16,2000);
            pc5.Info();
            Console.WriteLine($"{pc5.ToString()}");
            Console.WriteLine();
            Console.Write("Модель: ");
            string Model = Console.ReadLine();
            Console.Write("Частота процессора: ");
            double CPUfrequency = double.Parse(Console.ReadLine());
            Console.Write("Обьем оперативной памяти: ");
            int RAMcapacity = int.Parse(Console.ReadLine());
            Console.Write("Обьем жесткого диска:");
            int HDDcapacity = int.Parse(Console.ReadLine());
            PersonalPC pc6 = new PersonalPC(Model, CPUfrequency, RAMcapacity, HDDcapacity);
            pc6.Info();
            Console.WriteLine($"{pc6.ToString()}");
            Console.ReadLine();

        }
    }
}