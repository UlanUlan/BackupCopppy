using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackupCopy.Dal.Module;

namespace ReserveCopy
{
    public class GenerateDevice
    {
        public GenerateDevice()
        {
            HD = new List<HDD>();
            DV = new List<DVD>();
            FL = new List<Flash>();
        }
        public List<HDD> HD;
        public List<DVD> DV;
        public List<Flash> FL;
        private Random rand = new Random();
        public void GenerateFlash()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                Flash F = new Flash("{Model #");
                F.MemoryFlash = rand.Next(2048, 128000);
                F.typeDevice = (TypeDevice)rand.Next(0, 1);
                FL.Add(F);
            }
        }
        public void GenerateDVD()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                DVD D = new DVD(rand.Next(2, 1000), (TypeDVD)rand.Next(0, 1));
                D.SpeedRead = rand.Next(4, 10);
                D.typeDVD = (TypeDVD)rand.Next(0, 1);
                DV.Add(D);
            }
        }
        public void GenerateHDD()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                HDD H = new HDD(rand.Next(500, 1000));
                H.Cluster = rand.Next(1024, 128000);
                H.ClusterMemory = rand.Next(1024, 128000);
                H.typeDevice = (TypeDevice)rand.Next(0, 1);
                HD.Add(H);
            }
        }
    }
}
