namespace AbstractFactory
{
    public interface ICommandBuilder
    {
        // Build command to set the temperature set point
        string BuildSetTemperature(int temperature);

        // Build command to start the Oven
        string BuildStartCycle();
    }
}