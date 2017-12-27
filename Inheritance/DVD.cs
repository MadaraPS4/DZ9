using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DVD : Storage
    {
        public int SpeedReadWrite=4;

        public Enum Tip;

        public double Memory;

        public int[] arrayMemory;

        public DVD(double memory)
        {
            Memory = memory;
            arrayMemory = new int[9];
        }
     
        public override void Copy(int[] file)
        {
            int mem = 0;
            for(int i=0; i<file.Length; i++)
            {
                mem += file[i];
            }

            if (mem<=Memory)
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
                Console.WriteLine("Неоходимо количество ДВД дисков = " + mem % Memory);
            }

            
        }

        public override string GetDescription()
        {
            string s = "Этот двд диск является носителем информации для проигрывания и записи мультимедиа файлов";
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
                Console.WriteLine("Оставшаяся память = " + (Memory - sum));
            }
            else
            {
                Console.WriteLine("Оставшаяся память = " + Memory);
            }
        }


    }
}
