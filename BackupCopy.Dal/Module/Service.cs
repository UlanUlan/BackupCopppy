using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy.Dal.Module
{
    public class Service
    {
       // public static int Time { get; private set; }

        public double CalculateTotalMemory(List<HDD> hdd, List<Flash> flash, List<DVD> dvd)
        {
            double result = 0;
            foreach (HDD item in hdd)
                result += item.getMemory();
            foreach (Flash item in flash)
                result += item.getMemory();
            foreach (DVD item in dvd)
                result += item.getMemory();
            return result;
        }
        public TimeSpan CalculateTotalTime(List<HDD> hdd)
        {
            double sum = 0;
            foreach (HDD item in hdd)
            {
                sum += item.getMemory() / item.SpeedHDD;
            }
            return TimeSpan.FromMilliseconds(sum);
        }
        public TimeSpan CalculateTotalTime(List<Flash> flash)
        {
            double sum = 0;
            foreach (Flash item in flash)
            {
                sum += item.getMemory() / item.SpeedFlash;
            }
            return TimeSpan.FromMilliseconds(sum);
        }
        public TimeSpan CalculateTotalTime(List<DVD> dvd)
        {
            double sum = 0;
            foreach (DVD item in dvd)
            {
                sum += item.getMemory() / item.SpeedWrite; 
            }
            return TimeSpan.FromMilliseconds(sum);
        }
        private void DeviceCounter(Flash flash, double MemoryData, out int count)
        {
            count = Int32.Parse(Math.Ceiling(MemoryData / flash.MemoryFlash).ToString());
        }

        private int DeviceCounter(Flash flash, double MemoryData)
        {
            return Int32.Parse(Math.Ceiling(MemoryData / flash.MemoryFlash).ToString());
        }

        //private void DeviceCounter( HDD hdd, double MemoryData, out int count)
        //{
        //    count = Int32.Parse(Math.Ceiling(MemoryData / hdd.getMemory()).ToString());
        //}
        private int DeviceCounter(HDD hdd, double MemoryData)
        {
            return Int32.Parse(Math.Ceiling(MemoryData / hdd.getMemory()).ToString());
        }
        private void DeviceCounter( DVD dvd, double MemoryData, out int count)
        {
            count = Int32.Parse(Math.Ceiling(MemoryData / dvd.getMemory()).ToString());
        }
        private int DeviceCounter(DVD dvd, double MemoryData)
        {
            return Int32.Parse(Math.Ceiling(MemoryData / dvd.getMemory()).ToString());
        }
        public int getCounter(List<Flash> flash, double MemoryData)
        {
            foreach (Flash item in flash)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
            return 0;
        }
        public int getCounter(List<HDD> hdd, double MemoryData)
        {
            foreach (HDD item in hdd)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
            return 0;
        }
        public int getCounter(List<DVD> dvd, double MemoryData)
        {
            foreach (DVD item in dvd)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
            return 0;
        }
    }
}
