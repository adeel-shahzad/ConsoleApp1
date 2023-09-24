using System;
using DesignPattern.Creational.Builder.Product;
using DesignPattern.Creational.Builder;

namespace DesignPattern.Creational.Builder.Client
{
    public class BuilderClient {
        public BuilderClient() {
            CarBuilder carBuilder = new();
            Car car = carBuilder.SetModel("2021").SetName("Corolla").Build();
            Console.WriteLine($"Model: {car.Model}");
        }
    }
}