using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackupCopy.Dal.Module
{
    public class HDD : Storage
    {
        public HDD():  this(0)
        {

        }
        public HDD(int SpeedHDD) : this(SpeedHDD, TypeDevice.USB2)
        {
            
        }
        public HDD(int SpeedHDD, TypeDevice typeDevice) : base()
        {
            this.SpeedHDD = SpeedHDD;
            this.typeDevice = typeDevice;
        }
        public int SpeedHDD { get; set; }
        public TypeDevice typeDevice { get; set; }
        public int Cluster { get; set; }
        public int ClusterMemory { get; set; }
        public override double getMemory()
        {
            return ClusterMemory;
        }
        public override void Copy()
        {
            int sum = ClusterMemory / SpeedHDD;
            Console.WriteLine("Идёт копирование...");
            for (int i = 0; i < sum; i++)
            {
                Console.Write("-");
                Thread.Sleep(10);
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine("SpeedHDD: {0}\t TypeDevice: {1}\t Cluster: {2} ClusterMemory: {3} Memory: {4}\n", SpeedHDD, typeDevice, Cluster, ClusterMemory, getMemory());
        }
    }
}
