namespace FactoryMethod
{
    public class PlainTextResponseParser : IResponseParser
    {
        // Parse response and extract the temperature value
        public int ParseTemperature(string response)
        {
            if (response.StartsWith("TEMP:"))
            {
                string valuePart = response.Substring(5); // take text after "TEMP:"
                if (int.TryParse(valuePart, out int temperature))
                {
                    return temperature;
                }
                else
                {
                    throw new FormatException("Temperature value is not a valid integer");
                }
            }

            throw new FormatException("Invalid temperature response format");
        }

        // Parse response and extract the oven status
        public string ParseStatus(string response) => response.Trim();
    }

}