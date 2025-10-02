namespace AbstractFactory
{
    public interface IConnection
    {
        void Open();
        void Close();
        void Send(string message);
        string Read();
    }
}