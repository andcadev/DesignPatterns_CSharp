namespace AbstractFactory
{
    public interface IResponseParser
    {
        // Parse response and extract the temperature value
        int ParseTemperature(string response);

        // Parse response and extract the oven status
        string ParseStatus(string response);
    }
}