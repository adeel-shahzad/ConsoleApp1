namespace DesignPattern.Creational.AbstractFactory.Product
{
    public class DieselTransmission : ITransmission {
        public string TransmissionFor() {
            return "a diesel transmission";
        }
    }
}