using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    internal class PrototypeClient
    {
        public PrototypeClient() { 
            House house = (House)new House().GetClone();
            Console.WriteLine($"{house.WindowsType}");
        }
    }
}
