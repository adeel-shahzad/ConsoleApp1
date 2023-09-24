using DesignPattern.CreateChasis.AbstractFactory;
using DesignPattern.Creational.AbstractFactory.Product;

namespace DesignPattern.Creational.AbstractFactory
{
    public abstract class AFactory {
        public abstract IChasis CreateChasis();
        public abstract IEngine CreateEngine();
        public abstract ITransmission CreateTransmission();

        public static AFactory GetFactory() => new DieselFactory();
    }
}