namespace FactoryMethod
{
    public class OvenController
    {
        private readonly IConnection _connection;
        private readonly ICommandBuilder _commandBuilder;
        private readonly IResponseParser _responseParser;

        public OvenController(IOvenFactory factory)
        {
            // The objects creation is delegated to the concrete factory.
            _connection = factory.CreateConnection();
            _commandBuilder = factory.CreateCommandBuilder();
            _responseParser = factory.CreateResponseParser();
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public void SetTemperature(int temperature)
        {
            string command = _commandBuilder.BuildSetTemperature(temperature);
            _connection.Send(command);
        }

        public void StartCycle()
        {
            string command = _commandBuilder.BuildStartCycle();
            _connection.Send(command);
        }

        public int ReadTemperature()
        {
            string response = _connection.Read();
            return _responseParser.ParseTemperature(response);
        }
    }


}