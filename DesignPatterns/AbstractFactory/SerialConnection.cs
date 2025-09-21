namespace FactoryMethod
{
    public class SerialConnection : IConnection
    {
        public void Open() => Console.WriteLine("Serial connection opened");
        public void Close() => Console.WriteLine("Serial connection closed");
        public void Send(string message) => Console.WriteLine($"[Serial] Message sent: {message}");
        public string Read()
        {
            // Simulate read from the Serial port
            Console.WriteLine("[Serial] Receiving data...");

            // Simulated response
            return "TEMP:150";
        }

    }

}