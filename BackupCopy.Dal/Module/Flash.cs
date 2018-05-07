using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackupCopy.Dal.Module
{
    public enum TypeDevice { USB2, USB3 }
    public class Flash : Storage
    {
        public Flash(string model) : base("", model)
        {

        }
        public Flash() : this(1)
        {

        }
        public Flash(int SpeedFlash) : this(SpeedFlash, 1)
        {

        }
        public Flash(int SpeedFlash, double MemoryFlash)
        {
            this.SpeedFlash = 1;
            this.MemoryFlash = 1;
        }
        public int SpeedFlash { get; private set; }
        public double MemoryFlash { get; set; }
        private TypeDevice TypeDevice_;
        public TypeDevice typeDevice
        {
            get
            {
                return TypeDevice_;
            }
            set


            {
                TypeDevice_ = value;
                if (TypeDevice.USB2 == value)
                    SpeedFlash = 2000;
                else
                    SpeedFlash = 3000;
            }
        }

        public override double getMemory()
        {
            return MemoryFlash;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("SpeedFlash: {0}\t MemoryFlash: {1}\t Memory: {2}\n", SpeedFlash, MemoryFlash, getMemory());
        }
        public override void Copy()
        {
            int sum = (int)MemoryFlash / SpeedFlash;
            Console.WriteLine("Идёт копирование...");
            for (int i = 0; i < sum; i++)
            {
                Console.Write("-");
                Thread.Sleep(50);
            }
        }
    }
}
