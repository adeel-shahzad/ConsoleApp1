namespace DesignPattern.Creational.AbstractFactory.Product
{
    public class DieselChasis : IChasis {
        public string ChasisFor() {
            return "A diesel's chasis!";
        }
    }
}