using DesignPattern.Creational.FactoryMethod.Product;

namespace DesignPattern.Creational.FactoryMethod
{
    public abstract class DatabaseConnectivity {
        public abstract IConnectionString ConnectDatabase();

        public static DatabaseConnectivity GetFactory(FactoryType factoryType) {
            DatabaseConnectivity db;
            if(factoryType == FactoryType.Aurora) {
                db = new AuroraConnectivity();
            } else if(factoryType == FactoryType.MsSQL) {
                db = new MsSqlConnectivity();
            } else {
                db = null;
            }
            return db;
        }
    }

    class AuroraConnectivity : DatabaseConnectivity {
        public override IConnectionString ConnectDatabase() {
            return new AuroraConnectionString();
        }
    }

    class MsSqlConnectivity : DatabaseConnectivity {
        public override IConnectionString ConnectDatabase() {
            return new MsSqlConnectionString();
        }
    }

    public enum FactoryType {
        Aurora,
        MsSQL
    };
}