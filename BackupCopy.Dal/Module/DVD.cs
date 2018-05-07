using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackupCopy.Dal.Module
{
    public enum TypeDVD { OneSide, TwoSide }
    public class DVD : Storage
    {
        public DVD() :this(0)
        {

        }
        public DVD(double SpeedWrite) :this(SpeedWrite, TypeDVD.OneSide)
        {

        }
        public DVD(double _SpeedWrite, TypeDVD _typeDVD) :base()
        {
            typeDVD = _typeDVD;
            SpeedWrite = _SpeedWrite;
        }
        
        public DVD(string name)
        {
            base.Name = name;
            base.Model = "gsgas";
        }
        public double SpeedWrite { get; set; }
        public int SpeedRead { get; set; }
        public TypeDVD typeDVD { get; set; }

        public override double getMemory()
        {
            if (TypeDVD.OneSide == typeDVD)
                return 4700.0;
            else
                return 9400.0;
        }
     
        public override void PrintInfo()
        {
            Console.WriteLine("typeDVD: {0}\t Memory: {1}\t SpeedWrite: {2} SpeedRead: {3}\n", typeDVD, getMemory(), SpeedWrite, SpeedRead);
        }
        public override void Copy()
        {
            int sum = (int)getMemory() / (int)SpeedWrite;
            Console.WriteLine("Идёт копирование...");
            for (int i = 0; i < sum; i++)
            {
                Console.Write("-");
                Thread.Sleep(50);
            }
        }
    }
}
