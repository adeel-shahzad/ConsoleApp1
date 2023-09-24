using DesignPattern.Creational.Builder.Product;

namespace DesignPattern.Creational.Builder
{
    public class CarBuilder {
        private Car car = new();

        public CarBuilder SetName(string name) {
            car.Name = name;
            return this;
        }

        public CarBuilder SetModel(string model) {
            car.Model = model;
            return this;
        }

        public CarBuilder SetDisplacement(double displacement) {
            car.Displacement = displacement;
            return this;
        }

        public Car Build() {
            return car;
        }
    }
}