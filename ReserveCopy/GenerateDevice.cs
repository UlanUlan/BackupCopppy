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
            for (int i = 0; i < rand.Next(1,20); i++)
            {
                Flash F = new Flash(string.Format("{Model #{0}", rand.Next()));
                F.MemoryFlash = rand.Next(2048, 128000);
                F.typeDevice = (TypeDevice)rand.Next(0, 1);
                FL.Add(F);
            }
        }
    }
}
