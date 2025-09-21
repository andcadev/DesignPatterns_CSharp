namespace AbstractFactory
{
    public class LegacyOvenFactory : IOvenFactory
    {
        public IConnection CreateConnection() => new SerialConnection();

        public ICommandBuilder CreateCommandBuilder() => new PlainTextCommandBuilder();

        public IResponseParser CreateResponseParser() => new PlainTextResponseParser();
    }
}