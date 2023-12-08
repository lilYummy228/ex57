using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex57
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Soldier
    {
        public Soldier(string name, string armament, string rank, int dutyPeriod) 
        { 
            Name = name;
            Armament = armament;
            Rank = rank;
            DutyPeriod = dutyPeriod; 
        }

        public string Name { get; private set; }
        public string Armament { get; private set; }
        public string Rank { get; private set; }
        public int DutyPeriod { get; private set; }
    }
}
