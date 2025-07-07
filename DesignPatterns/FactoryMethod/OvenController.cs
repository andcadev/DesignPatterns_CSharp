namespace FactoryMethod
{
    // Abstract class that defines the Factory Method
    public abstract class OvenController
    {
        public void SetOvenTemperature(double temperature)
        {
            var connection = CreateConnection();
            connection.Open();
            connection.SetTemperature(temperature);
            connection.Close();
        }

        // This is the actual Factory Method definition
        protected abstract IDeviceConnection CreateConnection();
    }


}