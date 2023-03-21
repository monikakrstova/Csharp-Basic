using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05_Task02.Models
{
    public class Driver
    {
        public Driver()
        {
            
        }
        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public string Name { get; set; }
        public int Level { get; set; }

        
    }
}
