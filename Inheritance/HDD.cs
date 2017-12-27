using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class HDD : Storage
    {
        public int speedUSB;

        public int amountofSectors;

        public double volumeofSector;

        public int[] arrayMemory;

        public double Memory;

        public HDD(int Amount, double volumeSecotr)
        {
            amountofSectors = Amount;
            volumeofSector = volumeSecotr;
            arrayMemory = new int[9];
            Memory = Amount * volumeofSector;
            
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
                Console.WriteLine("Неоходимо количество жестких дисков = "+mem % Memory);
            }

            
        }

        public override string GetDescription()
        {
            string s = "Жесткие диски прездназначены для долговременного хранения информации";
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
                for(int i=0; i<arrayMemory.Length; i++)
                {
                    sum += arrayMemory[i];
                }
                Console.WriteLine("Оставшаяся память = " + (Memory - sum));
            }
            else
            {
                Console.WriteLine("Оставшаяся память = " + Memory);
            }
        }
    }
}
