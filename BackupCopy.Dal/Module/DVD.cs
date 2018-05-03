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
        public DVD(int SpeedWrite) :this(SpeedWrite, TypeDVD.OneSide)
        {

        }
        public DVD(int SpeedWrite, TypeDVD typeDVD) :base()
        {
            typeDVD = typeDVD;
            SpeedWrite = SpeedWrite;
        }
        
        public DVD(string name)
        {
            base.Name = name;
            base.Model = "gsgas";
        }
        public int SpeedWrite { get; set; }
        public int SpeedRead { get; set; }
        public TypeDVD typeDVD { get; set; }

        public override double getMemory()
        {
            if (TypeDVD.OneSide == typeDVD)
                return 4.7;
            else
                return 9.4;
        }
     
        public override void PrintInfo()
        {
            Console.WriteLine("typeDVD: {0}\t Memory: {1}\t SpeedWrite: {2} SpeedRead: {3}\n", typeDVD, getMemory(), SpeedWrite, SpeedRead);
        }
        public override void Copy()
        {
            int sum = (int)getMemory() / SpeedWrite;
            for (int i = 0; i < sum; i++)
            {
                Console.Write("-");
                Thread.Sleep(100);
            }
        }
    }
}
