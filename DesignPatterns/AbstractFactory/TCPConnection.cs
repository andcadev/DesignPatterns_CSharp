namespace AbstractFactory
{
    public class TcpConnection : IConnection
    {
        public void Open() => Console.WriteLine("TCP connection opened");
        public void Close() => Console.WriteLine("TCP connection closed");
        public void Send(string message) => Console.WriteLine($"[TCP] Message sent: {message}");
        public string Read()
        {
            // Simulate read from the Serial port
            Console.WriteLine("[TCP] Receiving data...");

            // Simulated response
            return "<Temperature><Value>250</Value></Temperature>";

        }
    }
}