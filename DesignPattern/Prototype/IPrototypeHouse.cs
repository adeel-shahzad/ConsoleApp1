using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    internal interface IPrototypeHouse
    {
        IPrototypeHouse GetClone();
    }
}
