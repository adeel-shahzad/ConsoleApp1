using DesignPattern.Creational.AbstractFactory;
using DesignPattern.Creational.AbstractFactory.Product;

namespace DesignPattern.Creational.AbstractFactory.Client
{
    public class AbstractFactoryClient {
        public AbstractFactoryClient() {
            AFactory factory = AFactory.GetFactory();
            var chasis = factory.CreateChasis();
            Console.WriteLine(chasis.ChasisFor());
        }
    }
}