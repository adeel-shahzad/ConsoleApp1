using DesignPattern.Creational.FactoryMethod.Product;

namespace DesignPattern.Creational.FactoryMethod
{
    public abstract class DatabaseConnectivity {
        public abstract IConnectionString ConnectDatabase();
    }

    class AuroraConnectivity : DatabaseConnectivity {
        public override IConnectionString ConnectDatabase() {
            return new AuroraConnectionString();
        }
    }
}