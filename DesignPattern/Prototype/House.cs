using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    internal class House : IPrototypeHouse
    {
        public string WindowsType { get; set; }

        public IPrototypeHouse GetClone()
        {
            var house = new House();
            house.WindowsType = "wooden";
            return house;
        }
    }
}
