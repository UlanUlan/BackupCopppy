using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy.Dal.Module
{
    public abstract class Storage
    {
        public Storage() : this("")
        {

        }
        public Storage(string Name) : this(Name, "")
        {

        }
        public Storage(string Name, string Model)
        {
            this.Name = Name;
            this.Model = Model;
        }
        public int Count { get; set; }
        public static int Time { get; set; }
        protected string Name { get; set; }
        public string Model { get; protected set; }
        public abstract double getMemory();
        public virtual void Copy()
        {
            Console.WriteLine("Copy Started");
            Time = 2;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Name: {0}\t Model: {1}\t Count: {2}\t Time {3}\n", Name, Model, Count, Time);
        }
    }
}
