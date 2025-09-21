namespace AbstractFactory
{
    public interface IOvenFactory
    {
        IConnection CreateConnection();
        ICommandBuilder CreateCommandBuilder();
        IResponseParser CreateResponseParser();
    }
}