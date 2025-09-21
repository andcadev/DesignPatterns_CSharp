namespace FactoryMethod
{
    public interface IOvenFactory
    {
        IConnection CreateConnection();
        ICommandBuilder CreateCommandBuilder();
        IResponseParser CreateResponseParser();
    }
}