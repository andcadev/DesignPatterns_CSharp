namespace FactoryMethod
{
    public class TCPConnection : IDeviceConnection
    {
        public void Open() => Console.WriteLine("TCP connection opened");
        public void Close() => Console.WriteLine("TCP connection closed");
        public void SetTemperature(double temperature) =>
            Console.WriteLine($"[TCP] Temperature set to {temperature} °C");
    }
}