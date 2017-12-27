using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage[] storage = new Storage[5];
            DVD dvd = new DVD(4000);
            HDD hdd = new HDD(3,10000);
            Flash flash = new Flash(5000);
            int[] file = new int[9];

            Random random = new Random();

            Console.WriteLine("Обьем памяти всех устройств= "+(dvd.GetMemory() + hdd.GetMemory() + flash.GetMemory()));

            Console.WriteLine("Копирование информации на устройства");
            for(int i=0; i<file.Length; i++)
            {
                file[i] = random.Next(100,500);
            }
            dvd.Copy(file);

            dvd.RemainingMemory();


            Console.ReadKey();
        }
    }

    enum Enum
    {
        OneSided,
        TwoSided
    }
}
