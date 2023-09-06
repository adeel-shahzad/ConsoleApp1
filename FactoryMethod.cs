using DesignPattern.Creational.FactoryMethod.Product;

namespace DesignPattern.Creational.FactoryMethod
{
    public abstract class DatabaseConnectivity {
        public abstract IConnectionString ConnectDatabase();

        public static DatabaseConnectivity GetFactory(FactoryType factoryType) {
            switch(factoryType) {
                when
            }
        }
    }

    class AuroraConnectivity : DatabaseConnectivity {
        public override IConnectionString ConnectDatabase() {
            return new AuroraConnectionString();
        }
    }

    public enum FactoryType {
        Aurora,
        Snowflake
    }
}