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
            GenerateDevice GenDev = new GenerateDevice();
            Console.WriteLine("Введите объём данных");
            double temp = Double.Parse(Console.ReadLine());
            GenDev.GenerateFlash();
            GenDev.GenerateDVD();
            GenDev.GenerateHDD();
            Service service = new Service();
            double totalMemory = service.CalculateTotalMemory(GenDev.HD, GenDev.FL, GenDev.DV);

            // Флэшки

            //Console.WriteLine("Общий объём флэшек = {0} ({1})", totalMemory, GenDev.FL.Count);
            //TimeSpan time1 = service.CalculateTotalTime(GenDev.FL);
            //Console.WriteLine(time1.TotalMinutes);
            //service.getCounter(GenDev.FL, temp);
            //foreach (Flash item in GenDev.FL)
            //{
            //    item.PrintInfo();
            //    item.Copy();
            //}

            // Харды

            //Console.WriteLine("Общий объём хардов = {0} ({1})", totalMemory, GenDev.HD.Count);
            //TimeSpan time2 = service.CalculateTotalTime(GenDev.HD);
            //Console.WriteLine(time2.TotalMinutes);
            //service.getCounter(GenDev.HD, temp);
            //foreach (HDD item in GenDev.HD)
            //{
            //    item.PrintInfo();
            //    item.Copy();
            //}

            // Диски

            //Console.WriteLine("Общий объём дисков = {0} ({1})", totalMemory, GenDev.DV.Count);
            //TimeSpan time3 = service.CalculateTotalTime(GenDev.DV);
            //Console.WriteLine(time3.TotalMinutes);
            //service.getCounter(GenDev.DV, temp);
            //foreach (DVD item in GenDev.DV)
            //{
            //    item.PrintInfo();
            //    item.Copy();
            //}



        }
    }
}
