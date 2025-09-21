namespace FactoryMethod
{
    public class ModernOvenFactory : IOvenFactory
    {
        public IConnection CreateConnection() => new TcpConnection();

        public ICommandBuilder CreateCommandBuilder() => new XmlCommandBuilder();

        public IResponseParser CreateResponseParser() => new XmlResponseParser();
    }


}