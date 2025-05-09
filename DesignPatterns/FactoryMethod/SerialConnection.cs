namespace FactoryMethod
{
    public class SerialConnection : IDeviceConnection
    {
        public void Open() => Console.WriteLine("Serial connection opened");
        public void Close() => Console.WriteLine("Serial connection closed");
        public void SetTemperature(double temperature) =>
            Console.WriteLine($"[Serial] Temperature set to {temperature} °C");
    }
}