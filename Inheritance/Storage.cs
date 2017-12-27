using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Storage
    {
        private string name;
        private string model;

        public abstract double GetMemory();

        public abstract void Copy(int[] file);

        public abstract void RemainingMemory();

        public abstract string GetDescription();


    }
}
