namespace DesignPattern.Creational.Builder
{
    public class CarBuilder {
        private string EngineType {get; set; } = null;
        private string Transmission {get; set; } = null;
        private int? Horsepower {get; set; } = null;
        private float? Displacement {get; set; } = null;

        public CarBuilder WithDieselEngine() {
            if(this.EngineType is null) this.EngineType = "Diesel";
            return this;
        }

        public CarBuilder WithPetrolEngine() {
            if(EngineType is null) this.EngineType = "Petrol";
            return this;
        }
    }
}