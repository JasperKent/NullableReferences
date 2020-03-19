namespace NullableReferences
{
    public class MotorCar
    {
        private Person? _driver;
        private Engine _engine;

        public MotorCar(Person? driver, Engine engine)
        {
            _driver = driver;
            _engine = engine;
        }

        public override string ToString()
        {
            return $"{_driver?.Name ?? "No one"} drives a {_engine.Capacity}cc car.";
        }
    }
}
