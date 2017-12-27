using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Flash : Storage
    {
        public double Memory;

        public int USBspeed=3;

        int[] arrayMemory;

        public Flash(double memory)
        {
            Memory = memory;
            arrayMemory = new int[9];
        }
        public override void Copy(int[] file)
        {
            int mem = 0;
            for (int i = 0; i < file.Length; i++)
            {
                mem += file[i];
            }


            if (mem <= Memory)
            {
                for (int i = 0; i < arrayMemory.Length; i++)
                {
                    arrayMemory[i] = file[i];
                }
                Console.WriteLine("Запись успешно выполнена");
            }
            else
            {
                Console.WriteLine("Нехватает места");
                Console.WriteLine("Неоходимо количество флэш носитилей = " + mem % Memory);
            }

        }

        public override string GetDescription()
        {
            string s = "Флеш носитель является одним из самих удобных преносчиков хранения информации";
            return s;
        }

        public override double GetMemory()
        {
            return Memory;
        }

        public override void RemainingMemory()
        {
            double sum = 0;
            if (arrayMemory != null)
            {
                for (int i = 0; i < arrayMemory.Length; i++)
                {
                    sum += arrayMemory[i];
                }
                Console.WriteLine("Оставшаяся память = "+(Memory - sum));
            }
            else
            {
                Console.WriteLine("Оставшаяся память = "+Memory);
            }
        }
    }
}
