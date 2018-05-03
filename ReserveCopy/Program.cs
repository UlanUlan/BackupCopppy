using BackupCopy.Dal.Module;
using ReserveCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    class Program
    {
        static void Main(string[] args)
        {
           // HDD hdd = new HDD();
           // / hdd.PrintInfo();
           // Flash flash = new Flash();
           // // flash.PrintInfo();
           // hdd.ClusterMemory = 100;
           // hdd.SpeedHDD = 10;
           // hdd.Copy();
            GenerateDevice GenDev = new GenerateDevice();
            Console.WriteLine("Введите объём данных");
            double temp = Double.Parse(Console.ReadLine());
            GenDev.GenerateFlash();
            Service service = new Service();
            double totalMemory = service.CalculateTotalMemory(new List<HDD>(), GenDev.FL, new List<DVD>());
            Console.WriteLine("Общий объём флэшек = {0} ({1})", totalMemory, GenDev.FL.Count);
            TimeSpan time1 = service.CalculateTotalTime(GenDev.FL);
            Console.WriteLine(time1.TotalMinutes);
            service.getCounter(GenDev.FL, temp);
            foreach (Flash item in GenDev.FL)
            {
                item.PrintInfo();
            }
        }
    }
}
