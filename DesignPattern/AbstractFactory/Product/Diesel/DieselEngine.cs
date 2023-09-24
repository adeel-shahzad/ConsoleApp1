namespace DesignPattern.Creational.AbstractFactory.Product
{
    public class DieselEngine : IEngine {
        public string EngineFor() {
            return "A diesel engine!!";
        }
    }
}