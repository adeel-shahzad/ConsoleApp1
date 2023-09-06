namespace DesignPattern.Creational.FactoryMethod.Product
{
    public interface IConnectionString {
        string GetConnectionString();
    }

    public class AuroraConnectionString : IConnectionString {

        public string GetConnectionString()
        {
            return "aurora://fetchUrlFromConfig:1234";
        }
    }

    public class MsSqlConnectionString : IConnectionString {

        public string GetConnectionString()
        {
            return "mssql://fetchUrlFromConfig:1234";
        }
    }
}