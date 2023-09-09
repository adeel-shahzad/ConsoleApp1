using DesignPattern.Creational.FactoryMethod.Product;

namespace DesignPattern.Creational.FactoryMethod.Client
{
    public class FactoryMethodClient {
        public FactoryMethodClient() {
            DatabaseConnectivity aurora = DatabaseConnectivity.GetFactory(FactoryType.MsSQL);
            IConnectionString connectionString = aurora.ConnectDatabase();
            Console.WriteLine($"{connectionString.GetConnectionString()}");
        }
    }
}