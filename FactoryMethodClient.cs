using DesignPattern.Creational.FactoryMethod.Product;

namespace DesignPattern.Creational.FactoryMethod.Client
{
    public class FactoryMethodClient {
        public FactoryMethodClient() {
            DatabaseConnectivity aurora = DatabaseConnectivity.GetFactory(FactoryType.Aurora);
            IConnectionString connectionString = aurora.ConnectDatabase();
            Console.WriteLine($"{connectionString.GetConnectionString()}");
        }
    }
}