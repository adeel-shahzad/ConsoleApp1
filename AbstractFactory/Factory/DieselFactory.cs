using DesignPattern.Creational.AbstractFactory.Product;
using DesignPattern.Creational.AbstractFactory;

namespace DesignPattern.CreateChasis.AbstractFactory
{
    public class DieselFactory : AFactory {
        public override IChasis CreateChasis() {
            return new DieselChasis();
        }
        public override IEngine CreateEngine() {
            return new DieselEngine();
        }
        public override ITransmission CreateTransmission() {
            return new DieselTransmission();
        }
    }
}