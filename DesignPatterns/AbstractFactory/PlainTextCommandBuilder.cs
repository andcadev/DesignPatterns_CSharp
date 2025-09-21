namespace FactoryMethod
{
    public class PlainTextCommandBuilder : ICommandBuilder
    {
        // Build command to set the temperature set point
        public string BuildSetTemperature(int temperature) => $"SET_TEMP_{temperature}";

        // Build command to start the Oven
        public string BuildStartCycle() => "START";
    }
}