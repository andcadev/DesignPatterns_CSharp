namespace FactoryMethod
{
    public interface IDeviceConnection
    {
        void Open();
        void Close();
        void SetTemperature(double temperature);
    }

    public class SerialConnection : IDeviceConnection
    {
        public void Open() => Console.WriteLine("Serial connection opened");
        public void Close() => Console.WriteLine("Serial connection closed");
        public void SetTemperature(double temperature) =>
            Console.WriteLine($"[Serial] Temperature set to {temperature} °C");
    }

    public class TCPConnection : IDeviceConnection
    {
        public void Open() => Console.WriteLine("TCP connection opened");
        public void Close() => Console.WriteLine("TCP connection closed");
        public void SetTemperature(double temperature) =>
            Console.WriteLine($"[TCP] Temperature set to {temperature} °C");
    }

}